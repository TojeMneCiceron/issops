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
    public partial class AddEditRule : Form
    {
        List<Variable> Variables { get; set; }
        List<Domain> Domains { get; set; }

        public List<Variable> NewVariables { get; set; }
        public List<Domain> NewDomains { get; set; }
        List<string> existingNames;

        public AddEditRule(Rule rule, List<string> names, List<Variable> variables, List<Domain> domains)
        {
            InitializeComponent();

            NewDomains = new List<Domain>();
            NewVariables = new List<Variable>();

            existingNames = names;

            Rule = rule;
            Variables = variables;
            Domains = domains;

            if (rule is null)
                tbName.Text = NewName();
            else
            {
                tbName.Text = rule.Name;
                tbReason.Text = rule.Reason;

                foreach (Fact fact in rule.Conditions)
                    lbConditions.Items.Add(fact);

                foreach (Fact fact in rule.Conclusions)
                    lbConclusions.Items.Add(fact);
            }

            CheckButtons();
        }

        public Rule Rule { get; set; }

        private string NewName()
        {
            if (existingNames.Count == 0)
                return "Rule1";

            var temp = existingNames.Where(x => new Regex(@"^Rule[0-9]+$").IsMatch(x)).ToList();

            if (temp.Count == 0)
                return "Rule" + (existingNames.Count + 1).ToString();
            else
            {
                int a = temp.Select(x => int.Parse(x.Substring(4))).Max();

                a = Math.Max(a, existingNames.Count) + 1;
                return "Rule" + a.ToString();
            }
        }

        private void CheckButtons()
        {
            bDeleteConc.Enabled = bEditConc.Enabled = !(lbConclusions.SelectedItem is null);
            bDeleteCond.Enabled = bEditCond.Enabled = !(lbConditions.SelectedItem is null);

            bOk.Enabled = tbName.Text != ""
                && lbConclusions.Items.Count > 0
                && lbConditions.Items.Count > 0
                && tbReason.Text != "";
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void tbReason_TextChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private bool CheckName()
        {
            string name = tbName.Text.Trim();
            if (existingNames.Contains(name))
                return Rule != null && name == Rule.Name;

            return true;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (!CheckName())
            {
                MessageBox.Show("Правило с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Fact> conds = new List<Fact>();
            foreach (Fact fact in lbConditions.Items)
                conds.Add(fact);

            List<Fact> concs = new List<Fact>();
            foreach (Fact fact in lbConclusions.Items)
                concs.Add(fact);

            Rule = new Rule(tbName.Text, conds, concs, tbReason.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bAddCond_Click(object sender, EventArgs e)
        {
            var aef = new AddFact(null, Variables, Domains, RulePart.Condition);

            if (aef.ShowDialog() == DialogResult.OK)
            {
                lbConditions.Items.Add(aef.Fact);
                //Variables.AddRange(aef.NewVariables);
                //Domains.AddRange(aef.NewDomains);
                NewVariables.AddRange(aef.NewVariables);
                NewDomains.AddRange(aef.NewDomains);
            }

            CheckButtons();
        }

        private void bDeleteCond_Click(object sender, EventArgs e)
        {
            lbConditions.Items.Remove(lbConditions.SelectedItem);

            CheckButtons();
        }

        private void bEditCond_Click(object sender, EventArgs e)
        {
            int i = lbConditions.SelectedIndex;

            var aef = new AddFact((Fact)lbConditions.Items[i], Variables, Domains, RulePart.Condition);

            if (aef.ShowDialog() == DialogResult.OK)
            {
                lbConditions.Items.RemoveAt(i);
                lbConditions.Items.Insert(i, aef.Fact);
                //Variables.AddRange(aef.NewVariables);
                //Domains.AddRange(aef.NewDomains);
                NewVariables.AddRange(aef.NewVariables);
                NewDomains.AddRange(aef.NewDomains);
            }

            CheckButtons();
        }

        private void bAddConc_Click(object sender, EventArgs e)
        {          
            var aef = new AddFact(null, Variables, Domains, RulePart.Conclusion);

            if (aef.ShowDialog() == DialogResult.OK)
            {
                lbConclusions.Items.Add(aef.Fact);
                //Variables.AddRange(aef.NewVariables);
                //Domains.AddRange(aef.NewDomains);
                NewVariables.AddRange(aef.NewVariables);
                NewDomains.AddRange(aef.NewDomains);
            }

            CheckButtons();
        }

        private void bDeleteConc_Click(object sender, EventArgs e)
        {
            lbConclusions.Items.Remove(lbConclusions.SelectedItem);

            CheckButtons();
        }

        private void bEditConc_Click(object sender, EventArgs e)
        {
            int i = lbConclusions.SelectedIndex;

            var aef = new AddFact((Fact)lbConclusions.Items[i], Variables, Domains, RulePart.Conclusion);

            if (aef.ShowDialog() == DialogResult.OK)
            {
                lbConclusions.Items.RemoveAt(i);
                lbConclusions.Items.Insert(i, aef.Fact);
                //Variables.AddRange(aef.NewVariables);
                //Domains.AddRange(aef.NewDomains);
                NewVariables.AddRange(aef.NewVariables);
                NewDomains.AddRange(aef.NewDomains);
            }

            CheckButtons();
        }

        private void lbConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void lbConclusions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }
    }
}
