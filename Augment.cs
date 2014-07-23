using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AugmentRandomiser
{
    class Augment
    {
        private static Augment root = new Augment("*");
        private const char C_ENTRY_SEPERATOR = '|';
        private const char C_DEPENDENCY_SEPERATOR = ',';

        public string identifier { get; private set; }
        public string fullName { get; set; }
        public int praxisCost { get; set; }
        public string[] dependencies { get; private set; }
        public bool isRoot { get; private set;  }

        public static Augment fromLine(string line)
        {
            string[] lines = line.Split(C_ENTRY_SEPERATOR);
            Augment result = new Augment();
         
            if (lines.Count() >= 1) result.identifier = lines[0].Trim();
            if (lines.Count() >= 2) result.praxisCost = Int32.Parse(lines[1].Trim());
            if (lines.Count() >= 3) result.dependencies = lines[2].Split(C_DEPENDENCY_SEPERATOR);
            if (lines.Count() >= 4) result.fullName = lines[3].Trim();

            for (int i = 0; i < result.dependencies.Count(); i++) result.dependencies[i] = result.dependencies[i].Trim();

            return result;
        }

        public static Augment getRoot()
        {
            return root;
        }

        public Augment()
        {
            identifier = "";
            fullName = "";
            praxisCost = -1;
            isRoot = false;
            dependencies = new String[0];
        }

        public Augment(string _identifier)
        {
            identifier = _identifier;
            fullName = "";
            praxisCost = -1;
            dependencies = new String[0];
            isRoot = _identifier == "*";
        }

        public Augment(string _identifier, string _fullname, int _cost, string[] _dependencies)
        {
            identifier = _identifier;
            fullName = _fullname;
            praxisCost = _cost;
            dependencies = _dependencies;
            isRoot = _identifier == "*";
        }

        public bool isTopLevelAug()
        {
            if (dependencies.Count() > 0)
                return dependencies.Contains("*");
            else
                return false;
        }

        public static bool operator ==(Augment lhs, Augment rhs)
        {
            return lhs.identifier == rhs.identifier;
        }

        public static bool operator !=(Augment lhs, Augment rhs)
        {
            return lhs.identifier != rhs.identifier;
        }

        public static bool operator ==(string lhs, Augment rhs)
        {
            return lhs == rhs.identifier;
        }

        public static bool operator !=(string lhs, Augment rhs)
        {
            return lhs != rhs.identifier;
        }

        public static bool operator ==(Augment lhs, string rhs)
        {
            return lhs.identifier == rhs;
        }

        public static bool operator !=(Augment lhs, string rhs)
        {
            return lhs.identifier != rhs;
        }
    }
}
