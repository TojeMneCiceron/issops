using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace щищ
{
    public partial class Input : Form
    {
        string result = "";
        public string Result { get => result; set => result = value; }

        public Input(string text)
        {
            InitializeComponent();

            tbInput.Text = text;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Result = tbInput.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
