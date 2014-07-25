using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace AugmentRandomiser
{
    class AugmentSession
    {
        public List<Augment> allAugments { get; private set;}
        public List<Augment> ownedAugments { get; private set;}
        public List<Augment> nextAugments { get; private set;}

        public AugmentSession()
        {
            allAugments = new List<Augment>();
            ownedAugments = new List<Augment>();
            nextAugments = new List<Augment>();
        }

        public void loadAugments(string path)
        {
            if (File.Exists(path))
            {
                allAugments.Clear();
                ownedAugments.Clear();
                nextAugments.Clear();
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine().Trim();
                        if (!line.StartsWith("#") && line.Length > 0)
                            allAugments.Add(Augment.fromLine(line));
                    }
                }
            }
            else
            {
                MessageBox.Show("Could not find augments file: " + path);
            }        
        }

        private static Augment findAugment(string augment, List<Augment> augs) 
        {
            foreach(Augment aug in augs)
            {
                if(augment == aug.identifier) return aug;
            }
            return Augment.getRoot();
        }

        public Augment getParentAugment(Augment augment)
        {
            if(augment.isRoot || augment.dependencies.Count() == 0) return Augment.getRoot();
            else return findAugment(augment.dependencies[0], allAugments);
        }

        public Augment getRootAugment(Augment augment)
        {
            Augment nextAugment = getParentAugment(augment);
            while(!nextAugment.isRoot)
            {
                augment = nextAugment;
                nextAugment = getParentAugment(augment);
            }
            return augment;
        }

        public List<Augment> getDependentAugs(Augment augment)
        {
            List<Augment> result = new List<Augment>();
            foreach (Augment aug in allAugments)
            {
                if (aug.dependencies[0] == augment.identifier)
                    result.Add(aug);
            }
            return result;
        }

        public void addAugmentToOwned(Augment augment)
        {
            if (!augment.isRoot && !ownedAugments.Contains(augment))
            {
                ownedAugments.Add(augment);
            }
        }

        public void resetOwnedAugments() {
            ownedAugments.Clear();
            ownedAugments.Add(Augment.getRoot());
        }

        public void updateAugmentLists() {
            bool loop = true;
            while(loop)
            {
                computeNextAugments();
                loop = addFreeAugments();
            }
        }

        private bool addFreeAugments() {
            bool addedAugment = false;

            for(int i=0; i<nextAugments.Count; i++)
            {
                Augment aug = nextAugments[i];
                if(aug.praxisCost == 0)
                {
                    ownedAugments.Add(aug);
                    nextAugments.RemoveAt(i--);
                    addedAugment = true;
                }
            }
            return addedAugment;
        }

        private void computeNextAugments() {    
            nextAugments.Clear();
            foreach(Augment aug in allAugments)
            {
                if(!ownedAugments.Contains(aug))
                {
                    Augment parent = getParentAugment(aug);
                    if(ownedAugments.Contains(parent))
                        nextAugments.Add(aug);
                }
            } 
        }
    }
}
