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
    public partial class AskVariable : Form
    {
        Fact fact;

        Variable variable;

        public Fact Fact { get => fact; set => fact = value; }

        public AskVariable(Variable variable)
        {
            InitializeComponent();

            this.variable = variable;
            lbQuestion.Text = variable.Question;
            cmbValue.DataSource = variable.Domain.Values;
        }

        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            bOk.Enabled = !(cmbValue.SelectedItem is null);
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            fact = new Fact(variable, (Value)cmbValue.SelectedItem);

            Close();
        }
    }
}
