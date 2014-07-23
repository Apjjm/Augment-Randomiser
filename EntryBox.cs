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
    public partial class EntryBox : Form
    {
        private string resultText = "";
        public EntryBox()
        {
            InitializeComponent();
        }

        public string getResultText()
        {
            return resultText;
        }

        public int getResultInt()
        {
            return Int32.Parse(resultText);
        }

        public int getResultHash()
        {
            return resultText.GetHashCode();
        }

        private void EntryBox_Load(object sender, EventArgs e)
        {

        }

        private void giveAug_Click(object sender, EventArgs e)
        {
            resultText = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void EntryBox_Shown(object sender, EventArgs e)
        {
            label.Text = this.Text + ":";
            textBox1.Text = "";
            resultText = "";
            //this.DialogResult = DialogResult.Cancel;
        }
    }
}
