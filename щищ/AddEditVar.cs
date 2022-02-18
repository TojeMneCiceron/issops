using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace щищ
{
    public partial class AddEditVar : Form
    {
        Variable variable;

        public Variable Variable { get => variable; set => variable = value; }
        public List<Domain> New_domains { get; set; } = new List<Domain>();
        List<string> existingNames;

        List<Domain> domains;

        public AddEditVar(Variable variable, List<string> names, List<Domain> domains, bool isConclusionPart = false)
        {
            InitializeComponent();

            foreach (Domain domain in domains)
                cmbDomain.Items.Add(domain);

            this.variable = variable;
            this.domains = domains;
            existingNames = names;

            rb1.Enabled = !isConclusionPart;

            if (variable is null)
                tbName.Text = NewName();
            else
            {
                tbName.Text = variable.Name;

                switch (variable.VType)
                {
                    case V_Type.In:
                        rb1.Checked = true;
                        break;
                    case V_Type.Out:
                        rb2.Checked = true;
                        break;
                    case V_Type.In_Out:
                        rb3.Checked = true;
                        break;
                }

                cmbDomain.SelectedItem = variable.Domain;
            }

            CheckButtons();
        }

        private string NewName()
        {
            if (existingNames.Count == 0)
                return "Variable1";

            var temp = existingNames.Where(x => new Regex(@"^Variable[0-9]+$").IsMatch(x)).ToList();

            if (temp.Count == 0)
                return "Variable" + (existingNames.Count + 1).ToString();
            else
            {
                int a = temp.Select(x => int.Parse(x.Substring(8))).Max();

                a = Math.Max(a, existingNames.Count) + 1;
                return "Variable" + a.ToString();
            }
        }

        private void CheckButtons()
        {
            bOk.Enabled = tbName.Text != ""
                && (rb1.Checked || rb2.Checked || rb3.Checked)
                && !(cmbDomain.SelectedItem is null);
        }                

        private void bAddDomain_Click(object sender, EventArgs e)
        {
            var aed = new AddEditDomain(null, domains.Select(x => x.Name).ToList());

            if (aed.ShowDialog() == DialogResult.OK)
            {
                cmbDomain.Items.Add(aed.Domain);
                domains.Add(aed.Domain);
                New_domains.Add(aed.Domain);

                cmbDomain.SelectedIndex = cmbDomain.Items.Count - 1;
            }
        }

        private bool CheckName()
        {
            string name = tbName.Text.Trim();
            if (existingNames.Contains(name))
                return variable != null && name == variable.Name;

            return true;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (!CheckName())
            {
                MessageBox.Show("Переменная с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            V_Type type;

            if (rb1.Checked)
                type = V_Type.In;
            else
            if (rb2.Checked)
                type = V_Type.Out;
            else
                type = V_Type.In_Out;

            variable = new Variable(tbName.Text, (Domain)cmbDomain.SelectedItem, type);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void cmbDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }
    }
}
