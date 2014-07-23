using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AugmentRandomiser
{
    public partial class Form1 : Form
    {
        Random random;
        AugmentSession session;
        Augment currentAugment;

        public Form1()
        {
            InitializeComponent();
            session = new AugmentSession();
            currentAugment = Augment.getRoot();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            session.loadAugments("upgrades.txt");
            session.resetOwnedAugments();
            session.updateAugmentLists();
            selectRandomAug();
            populateTreeView();
            updateTreeView();
            updateButton();
            if (lvAugs.Nodes.Count > 0) lvAugs.Nodes[0].EnsureVisible();
        }

        private void seedRNG(int seed)
        {
            random = new Random(seed);
        }

        private void selectRandomAug()
        {
            if (session.nextAugments.Count > 0)
            {
                int i = random.Next(session.nextAugments.Count);
                currentAugment = session.nextAugments[i];
            }
            else currentAugment = Augment.getRoot();
        }

        private void giveAug_Click(object sender, EventArgs e)
        {
            if (currentAugment.isRoot) return;
            session.addAugmentToOwned(currentAugment);
            session.updateAugmentLists();
            updateTreeView();
            ensureVisibleAugment(currentAugment);
            selectRandomAug();
            updateButton();
        }

        private void updateButton()
        {
            if (currentAugment.isRoot)
                giveAug.Text = "No Augments Remaining";
            else
                giveAug.Text = currentAugment.fullName + " (" + currentAugment.praxisCost + ")";
        }

        private void ensureVisibleAugment(Augment augment)
        {
            foreach (TreeNode node in lvAugs.Nodes)
            {
                ensureVisibleAugment_Recurse(node, augment);
            }
        }

        private void ensureVisibleAugment_Recurse(TreeNode root, Augment augment)
        {
            if (root.Tag == augment)
            {
                root.EnsureVisible();
                root.BackColor = Color.Gray;
            }
            else
            {
                foreach (TreeNode node in root.Nodes)
                {
                    ensureVisibleAugment_Recurse(node, augment);
                }
            }
        }

        private void updateTreeView()
        {
            lvAugs.BeginUpdate();
            foreach (TreeNode node in lvAugs.Nodes)
            {
                updateTreeView_recurse(node);           
            }
            lvAugs.EndUpdate();
            lvAugs.Refresh();
        }

        private void updateTreeView_recurse(TreeNode root)
        {
            Augment aug = (Augment)root.Tag;
            root.BackColor = lvAugs.BackColor;
            if (session.ownedAugments.Contains(aug))
            {
                root.Text = aug.fullName;
                root.ForeColor = Color.Gold;
            }
            else if (session.nextAugments.Contains(aug))
            {
                root.EnsureVisible();
                root.Text = aug.fullName + " (" + aug.praxisCost + ")";
                root.ForeColor = Color.Goldenrod;
            }
            else
            {
                root.Text = aug.fullName + " (" + aug.praxisCost + ")";
                root.ForeColor = Color.Gray;
            }

            if (root.Nodes.Count > 0)
            {
                if (root.IsExpanded)
                    root.Text = "- " + root.Text;
                else
                    root.Text = "+ " + root.Text;
            }

            foreach (TreeNode node in root.Nodes)
                updateTreeView_recurse(node);
        }

        private void populateTreeView()
        {
            lvAugs.BeginUpdate();
            lvAugs.Nodes.Clear();
            foreach (Augment aug in session.allAugments)
            {
                if (aug.isTopLevelAug())
                {
                    var node = lvAugs.Nodes.Add(aug.fullName);
                    node.Tag = aug;
                    populateTreeView_recurse(node);
                }
            }
            lvAugs.EndUpdate();
        }

        private void populateTreeView_recurse(TreeNode root)
        {   
            foreach (Augment aug in session.getDependentAugs((Augment)root.Tag))
            {
                TreeNode node = root.Nodes.Add(aug.fullName);
                node.Tag = aug;
                populateTreeView_recurse(node);
            }
        }

        private void lvAugs_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session.resetOwnedAugments();
            session.updateAugmentLists();
            lvAugs.CollapseAll();
            updateTreeView();
            selectRandomAug();
            updateButton();
            if(lvAugs.Nodes.Count > 0) lvAugs.Nodes[0].EnsureVisible();
        }

        private void setSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryBox box = new EntryBox();
            box.Text = "Enter Seed";
            DialogResult r = box.ShowDialog();
            if (r == DialogResult.OK)
            {
                seedRNG(box.getResultHash());
                resetToolStripMenuItem_Click(sender, e);
            }
        }

        private void giveAugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryBox box = new EntryBox();
            box.Text = "Enter Augment Name";
            DialogResult r = box.ShowDialog(this);
            if (r == DialogResult.OK)
            {
                string text = box.getResultText().Replace(" ","").Trim().ToLower();
                foreach (Augment aug in session.allAugments)
                {
                    if (aug.fullName.ToLower().Replace(" ", "") == text)
                    {
                        tryGiveAug(aug);
                        break;
                    }
                }
                
            }
        }

        private void tryGiveAug(Augment aug)
        {
            if (session.nextAugments.Contains(aug))
            {
                session.addAugmentToOwned(aug);
                session.updateAugmentLists();
                updateTreeView();
                ensureVisibleAugment(aug);
                if (aug == currentAugment)
                {
                    selectRandomAug();
                    updateButton();
                }
            }
        }

        private void lvAugs_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Text = e.Node.Text.Replace('+', '-');
        }

        private void lvAugs_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.Text = e.Node.Text.Replace('-', '+');
        }

        private void collapseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAugs.CollapseAll();
        }

        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAugs.ExpandAll();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
