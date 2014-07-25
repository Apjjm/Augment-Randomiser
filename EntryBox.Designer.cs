namespace AugmentRandomiser
{
    partial class EntryBox
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
            this.giveAug = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giveAug
            // 
            this.giveAug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.giveAug.BackColor = System.Drawing.Color.Gold;
            this.giveAug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.giveAug.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveAug.Location = new System.Drawing.Point(218, 23);
            this.giveAug.Name = "giveAug";
            this.giveAug.Size = new System.Drawing.Size(64, 23);
            this.giveAug.TabIndex = 2;
            this.giveAug.Text = "Ok";
            this.giveAug.UseVisualStyleBackColor = false;
            this.giveAug.Click += new System.EventHandler(this.giveAug_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Gold;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 14);
            this.label.TabIndex = 4;
            this.label.Text = "<SET ME>";
            // 
            // EntryBox
            // 
            this.AcceptButton = this.giveAug;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(294, 65);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.giveAug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EntryBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EntryBox";
            this.Load += new System.EventHandler(this.EntryBox_Load);
            this.Shown += new System.EventHandler(this.EntryBox_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giveAug;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label;

    }
}