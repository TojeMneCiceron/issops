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
    public enum RulePart
    {
        Condition, Conclusion
    }
    public partial class AddFact : Form
    {
        public Fact Fact { get; set; }
        List<Variable> Variables { get; set; }
        List<Domain> Domains { get; set; }
        public List<Variable> NewVariables { get; set; }
        public List<Domain> NewDomains { get; set; }
        RulePart Rp;

        public AddFact(Fact fact, List<Variable> variables, List<Domain> domains, RulePart rp)
        {
            InitializeComponent();

            NewDomains = new List<Domain>();
            NewVariables = new List<Variable>();

            Fact = fact;
            Variables = variables;
            Domains = domains;
            Rp = rp;

            switch (rp)
            {
                case RulePart.Condition:
                    foreach (Variable v in variables)
                        cmbVar.Items.Add(v);
                    break;
                case RulePart.Conclusion:
                    foreach (Variable v in variables.Where(x => x.VType != V_Type.In).ToList())
                        cmbVar.Items.Add(v);
                    break;
            }

            if (fact is null)
            {
                if (variables.Count > 0 && rp == RulePart.Condition 
                    || variables.Where(x => x.VType != V_Type.In).ToList().Count > 0 && rp == RulePart.Conclusion)
                    cmbVar.SelectedItem = cmbVar.Items[0];                
            }
            else
            {
                foreach (Variable i in cmbVar.Items)
                { 
                    if (i.Name == fact.Variable.Name)
                        cmbVar.SelectedItem = i; 
                }

                foreach (Value i in cmbValue.Items)
                {
                    if (i.Name == fact.Value.Name)
                        cmbValue.SelectedItem = i;
                }
                //cmbValue.SelectedItem = fact.Value;
            }

            CheckButtons();
        }

        private void CheckButtons()
        {
            bOk.Enabled = !(cmbValue.SelectedItem is null || cmbVar.SelectedItem is null);
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Fact = new Fact((Variable)cmbVar.SelectedItem, (Value)cmbValue.SelectedItem);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbValue.DataSource = ((Variable)cmbVar.SelectedItem).Domain.Values;

            CheckButtons();
        }

        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void bAddVar_Click(object sender, EventArgs e)
        {
            var av = new AddEditVar(null, Variables.Select(x => x.Name).ToList(), Domains, Rp == RulePart.Conclusion);

            if (av.ShowDialog() != DialogResult.OK)
                return;

            Variables.Add(av.Variable);
            NewVariables.Add(av.Variable);
            Domains.AddRange(av.New_domains);
            NewDomains.AddRange(av.New_domains);

            cmbVar.Items.Add(av.Variable);

            //switch (Rp)
            //{
            //    case RulePart.Condition:
            //        cmbVar.Items.Add(av.Variable);
            //        break;
            //    case RulePart.Conclusion:
            //        if (av.Variable.VType != V_Type.In)
            //            cmbVar.Items.Add(av.Variable);
            //        break;
            //}

            cmbVar.SelectedItem = Variables[Variables.Count - 1];
        }
    }
}
