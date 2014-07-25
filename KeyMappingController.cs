using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace AugmentRandomiser
{
    class KeyMappingController
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        public static bool IsKeyDown(System.Windows.Forms.Keys Key)  {
            return 0 != GetAsyncKeyState((int)Key);
        }


        private class KeyMapping
        {
            public string action;
            public Action<Object, EventArgs> handler;
            public KeyMapping(string action, Action<Object, EventArgs> handler) 
            {
                this.action = action;
                this.handler = handler;
            }
            
        }
        private class KeyData
        {
            public bool pressed;
            public Keys key;
            public string action;

            public KeyData(Keys key, string action) {
                this.pressed = false;
                this.key = key;
                this.action = action;
            }
        }

        List<KeyMapping> keyMappings;
        List<KeyData> keyData;

        public KeyMappingController()
        {
            keyMappings = new List<KeyMapping>();
            keyData = new List<KeyData>();
        }

        public void addKeyActionPair(Keys key, string action)
        {
            keyData.Add(new KeyData(key, action));
        }

        public void addActionMapping(string action, Action<Object, EventArgs> actionHandler)
        {
            keyMappings.Add(new KeyMapping(action, actionHandler));
        }

        public void addKeyActionPairsFromFile(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    KeysConverter converter = new KeysConverter();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine().Trim();
                        if (line.StartsWith("#") || line.Length == 0) continue;
                        string[] mapping = line.Split(':');
                        if (mapping.Length == 2)
                        {
                            object key = converter.ConvertFromString(mapping[0].Trim());
                            if (key != null) addKeyActionPair((Keys)key, mapping[1].Trim());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Could not find augments file: " + path);
            }      
        }

        public void takeAction(string action)
        {
            foreach (KeyMapping k in keyMappings)
            {
                if (k.action == action)
                {
                    k.handler(this, new EventArgs());
                }
            }
        }

        public void step()
        {
            for(int i=0; i<keyData.Count; ++i)
            {
                KeyData k = keyData[i];
                if (IsKeyDown(k.key))
                {
                    if (!k.pressed)
                    {
                        k.pressed = true;
                        takeAction(k.action);
                    }
                }
                else
                {
                    k.pressed = false;
                }
            }
        }
    }
}
