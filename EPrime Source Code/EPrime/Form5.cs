using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPrime
{
    public partial class OptionsForm : Form
    {
        public string text = "";
        public string id = "";
        public int index = 0;
        private adminForm form;

        public OptionsForm(int index,string text, string id, adminForm sender)
        {
            InitializeComponent();
            this.text = text;
            this.id = id;
            this.index = index;
            this.form = sender;
            textBox.Text = text;
            idBox.Text = id;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            form.setOptions(index,textBox.Text,idBox.Text);
            Dispose();
        }
    }
}
