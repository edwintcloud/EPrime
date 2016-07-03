using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPrime
{
    public partial class helpForm : Form
    {
        private Button button1 = null;
        public helpForm(string helpText,Button b1)
        {
            InitializeComponent();
            button1 = b1;
            helpBox.Text = helpText;
        }

        private void helpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            button1.Enabled = true;
        }

        private void helpBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
