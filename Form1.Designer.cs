namespace AugmentRandomiser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvAugs = new System.Windows.Forms.TreeView();
            this.giveAug = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveAugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAugs
            // 
            this.lvAugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvAugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAugs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAugs.ForeColor = System.Drawing.Color.White;
            this.lvAugs.Location = new System.Drawing.Point(12, 27);
            this.lvAugs.Name = "lvAugs";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            this.lvAugs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.lvAugs.ShowPlusMinus = false;
            this.lvAugs.ShowRootLines = false;
            this.lvAugs.Size = new System.Drawing.Size(297, 351);
            this.lvAugs.TabIndex = 0;
            this.lvAugs.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.lvAugs_AfterCollapse);
            this.lvAugs.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.lvAugs_AfterExpand);
            this.lvAugs.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.lvAugs_BeforeSelect);
            // 
            // giveAug
            // 
            this.giveAug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giveAug.BackColor = System.Drawing.Color.Gold;
            this.giveAug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.giveAug.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveAug.Location = new System.Drawing.Point(12, 383);
            this.giveAug.Name = "giveAug";
            this.giveAug.Size = new System.Drawing.Size(285, 23);
            this.giveAug.TabIndex = 1;
            this.giveAug.Text = "button1";
            this.giveAug.UseVisualStyleBackColor = false;
            this.giveAug.Click += new System.EventHandler(this.giveAug_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSeedToolStripMenuItem,
            this.expandToolStripMenuItem,
            this.collapseToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.giveAugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // setSeedToolStripMenuItem
            // 
            this.setSeedToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSeedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setSeedToolStripMenuItem.Name = "setSeedToolStripMenuItem";
            this.setSeedToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.setSeedToolStripMenuItem.Text = "Seed";
            this.setSeedToolStripMenuItem.Click += new System.EventHandler(this.setSeedToolStripMenuItem_Click);
            // 
            // giveAugToolStripMenuItem
            // 
            this.giveAugToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveAugToolStripMenuItem.Name = "giveAugToolStripMenuItem";
            this.giveAugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.giveAugToolStripMenuItem.Text = "Cheat";
            this.giveAugToolStripMenuItem.Click += new System.EventHandler(this.giveAugToolStripMenuItem_Click);
            // 
            // collapseToolStripMenuItem
            // 
            this.collapseToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collapseToolStripMenuItem.Name = "collapseToolStripMenuItem";
            this.collapseToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.collapseToolStripMenuItem.Text = "Collapse";
            this.collapseToolStripMenuItem.Click += new System.EventHandler(this.collapseToolStripMenuItem_Click);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.expandToolStripMenuItem.Text = "Expand";
            this.expandToolStripMenuItem.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(309, 412);
            this.Controls.Add(this.giveAug);
            this.Controls.Add(this.lvAugs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(325, 40000);
            this.MinimumSize = new System.Drawing.Size(325, 100);
            this.Name = "Form1";
            this.Text = "Augment Randomiser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView lvAugs;
        private System.Windows.Forms.Button giveAug;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveAugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandToolStripMenuItem;
    }
}

