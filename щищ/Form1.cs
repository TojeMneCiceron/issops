using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace щищ
{
    public partial class Form1 : Form
    {
        MLV mlv;
        KBase kbase;

        public Form1()
        {
            InitializeComponent();

            kbase = new KBase();

            CheckButtons();
            ResizeLv(lvRules);
            ResizeLv(lvVars);
            ResizeLv(lvDomens);

            SetDragDrop();
        }

        private void SetDragDrop()
        {
            lvRules.AllowDrop = true;
            lvRules.DragDrop += new DragEventHandler(lvRules_DragDrop);
            lvRules.MouseDown += new MouseEventHandler(lvRules_MouseDown);
            lvRules.DragOver += new DragEventHandler(lvRules_DragOver);
        }

        private void lvRules_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvRules.SelectedItems.Count == 0) return;
            lvRules.DoDragDrop(lvRules.SelectedItems[0], DragDropEffects.Move);
        }

        private void lvRules_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lvRules_DragDrop(object sender, DragEventArgs e)
        {
            Point p = lvRules.PointToClient(new Point(e.X, e.Y));
            int index = lvRules.GetItemAt(p.X, p.Y).Index;
            if (index < 0) index = lvRules.Items.Count - 1;
            ListViewItem data = lvRules.SelectedItems[0];
            lvRules.Items.Remove(data);
            lvRules.Items.Insert(index, data);
        }

        private void CheckButtons()
        {
            bDeleteDomen.Enabled = bEditDomen.Enabled = lvDomens.SelectedItems.Count > 0;
            bDeleteVar.Enabled = bEditVar.Enabled = lvVars.SelectedItems.Count > 0;
            bDeleteRule.Enabled = bEditRule.Enabled = lvRules.SelectedItems.Count > 0;

            //консультацияToolStripMenuItem.Enabled = cmbGoal.SelectedIndex != -1;
        }

        private bool isUsed(Variable variable)
        {
            foreach (ListViewItem lvi in lvRules.Items)
            {
                Rule rule = (Rule)lvi.Tag;
                if (rule.Conditions.Where(x => x.Variable.Name == variable.Name).ToList().Count > 0
                    || rule.Conclusions.Where(x => x.Variable.Name == variable.Name).ToList().Count > 0)
                    return true;
            }
            return false;
        }

        private bool isUsed(Domain domain)
        {
            foreach (ListViewItem lvi in lvVars.Items)
            {
                Variable variable = (Variable)lvi.Tag;
                if (variable.Domain.Name == domain.Name)
                    return true;
            }
            return false;
        }

        private void UpdateKBase()
        {
            List<Rule> r = new List<Rule>();
            List<Variable> v = new List<Variable>();
            List<Domain> d = new List<Domain>();

            foreach (ListViewItem item in lvRules.Items)
                r.Add((Rule)item.Tag);
            foreach (ListViewItem item in lvVars.Items)
                v.Add((Variable)item.Tag);
            foreach (ListViewItem item in lvDomens.Items)
                d.Add((Domain)item.Tag);

            kbase.Update(r, v, d, (Variable)cmbGoal.SelectedItem);
        }

        private List<string> GetNames(ListView lv)
        {
            List<string> names = new List<string>();

            foreach (ListViewItem item in lv.Items)
                names.Add(item.SubItems[0].Text);

            return names;
        }

        private List<Variable> GetVariables(ListView lv)
        {
            List<Variable> values = new List<Variable>();

            foreach (ListViewItem item in lv.Items)
                values.Add((Variable)item.Tag);

            return values;
        }

        private List<Domain> GetDomains(ListView lv)
        {
            List<Domain> values = new List<Domain>();

            foreach (ListViewItem item in lv.Items)
                values.Add((Domain)item.Tag);

            return values;
        }

        private void bAddRule_Click(object sender, EventArgs e)
        {
            //if (lvVars.Items.Count == 0)
            //{
            //    MessageBox.Show("Создайте хотя бы одну переменную", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            var aer = new AddEditRule(null, GetNames(lvRules), GetVariables(lvVars), GetDomains(lvDomens));

            if (aer.ShowDialog() == DialogResult.OK)
            {
                var new_item = new ListViewItem(new[] {
                        aer.Rule.Name,
                        aer.Rule.ToString(),
                        aer.Rule.Reason
                    });
                new_item.Tag = aer.Rule;

                if (lvRules.SelectedItems.Count == 0)
                {
                    lvRules.Items.Add(new_item);
                }
                else
                {
                    lvRules.Items.Insert(lvRules.SelectedIndices[0] + 1, new_item);
                }
            }

            foreach (Variable variable in aer.NewVariables)
            {
                var new_item = new ListViewItem(new[] {
                    variable.Name,
                    variable.Type(),
                    variable.Domain.Name,
                    variable.Question
                });

                new_item.Tag = variable;

                lvVars.Items.Add(new_item);
                cmbGoal.Items.Add(variable);
            }

            foreach (Domain domain in aer.NewDomains)
            {
                var new_item = new ListViewItem(new[] {
                    domain.Name,
                    domain.ToString()
                });
                new_item.Tag = domain;

                lvDomens.Items.Add(new_item);
            }

            CheckButtons();
            ResizeLv(lvRules);
            ResizeLv(lvVars);
            ResizeLv(lvDomens);
        }

        private void bDeleteRule_Click(object sender, EventArgs e)
        {
            int i = lvRules.SelectedIndices[0];

            lvRules.Items.RemoveAt(i);

            CheckButtons();
        }

        private void bEditRule_Click(object sender, EventArgs e)
        {
            int i = lvRules.SelectedIndices[0];

            var aer = new AddEditRule((Rule)lvRules.SelectedItems[0].Tag, GetNames(lvRules), GetVariables(lvVars), GetDomains(lvDomens));

            if (aer.ShowDialog() == DialogResult.OK)
            {
                lvRules.Items[i] = new ListViewItem(new[] {
                    aer.Rule.Name,
                    aer.Rule.ToString(),
                    aer.Rule.Reason
                });
                lvRules.Items[i].Tag = aer.Rule;
            }

            foreach (Variable variable in aer.NewVariables)
            {
                var new_item = new ListViewItem(new[] {
                    variable.Name,
                    variable.Type(),
                    variable.Domain.Name,
                    variable.Question
                });

                new_item.Tag = variable;

                lvVars.Items.Add(new_item);
                cmbGoal.Items.Add(variable);
            }

            foreach (Domain domain in aer.NewDomains)
            {
                var new_item = new ListViewItem(new[] {
                    domain.Name,
                    domain.ToString()
                });
                new_item.Tag = domain;

                lvDomens.Items.Add(new_item);
            }

            CheckButtons();
            ResizeLv(lvRules);
            ResizeLv(lvVars);
            ResizeLv(lvDomens);
        }

        private void bAddVar_Click(object sender, EventArgs e)
        {
            var aev = new AddEditVar(null, GetNames(lvVars), GetDomains(lvDomens));

            if (aev.ShowDialog() == DialogResult.OK)
            {
                var new_item = new ListViewItem(new[] {
                    aev.Variable.Name,
                    aev.Variable.Type(),
                    aev.Variable.Domain.Name,
                    aev.Variable.Question
                });

                new_item.Tag = aev.Variable;

                if (lvRules.SelectedItems.Count == 0)
                {
                    lvVars.Items.Add(new_item);

                    cmbGoal.Items.Add(aev.Variable);
                }
                else
                {
                    lvVars.Items.Insert(lvRules.SelectedIndices[0] + 1, new_item);

                    cmbGoal.Items.Insert(lvRules.SelectedIndices[0] + 1, new_item);
                }
            }

            foreach (Domain domain in aev.New_domains)
            {
                var new_item = new ListViewItem(new[] {
                    domain.Name,
                    domain.ToString()
                });
                new_item.Tag = domain;

                lvDomens.Items.Add(new_item);
            }

            CheckButtons();
            ResizeLv(lvVars);
            ResizeLv(lvDomens);
        }

        private void bDeleteVar_Click(object sender, EventArgs e)
        {
            if (isUsed((Variable)lvVars.SelectedItems[0].Tag))
            {
                MessageBox.Show("Переменная используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int i = lvVars.SelectedIndices[0];

            lvVars.Items.RemoveAt(i);

            cmbGoal.Items.RemoveAt(i);

            CheckButtons();
        }

        private void bEditVar_Click(object sender, EventArgs e)
        {
            if (isUsed((Variable)lvVars.SelectedItems[0].Tag))
            {
                MessageBox.Show("Переменная используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int i = lvVars.SelectedIndices[0];
            var aev = new AddEditVar((Variable)lvVars.SelectedItems[0].Tag, GetNames(lvVars), GetDomains(lvDomens));

            if (aev.ShowDialog() == DialogResult.OK)
            {
                lvVars.Items[i] = new ListViewItem(new[] {
                    aev.Variable.Name,
                    aev.Variable.Type(),
                    aev.Variable.Domain.Name,
                    aev.Variable.Question
                });
                lvVars.Items[i].Tag = aev.Variable;

                cmbGoal.Items[i] = aev.Variable;
            }

            foreach (Domain domain in aev.New_domains)
            {
                var new_item = new ListViewItem(new[] {
                    domain.Name,
                    domain.ToString()
                });
                new_item.Tag = domain;

                lvDomens.Items.Add(new_item);
            }

            CheckButtons();
            ResizeLv(lvVars);
            ResizeLv(lvDomens);
        }

        private void bAddDomen_Click(object sender, EventArgs e)
        {
            var aed = new AddEditDomain(null, GetNames(lvDomens));

            if (aed.ShowDialog() == DialogResult.OK)
            {
                var new_item = new ListViewItem(new[] {
                    aed.Domain.Name,
                    aed.Domain.ToString()
                });

                new_item.Tag = aed.Domain;

                if (lvDomens.SelectedItems.Count == 0)
                {
                    lvDomens.Items.Add(new_item);
                }
                else
                {
                    lvDomens.Items.Insert(lvRules.SelectedIndices[0] + 1, new_item);
                }
            }

            CheckButtons();
            ResizeLv(lvDomens);
        }

        private void bDeleteDomen_Click(object sender, EventArgs e)
        {
            if (isUsed((Domain)lvDomens.SelectedItems[0].Tag))
            {
                MessageBox.Show("Домен используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int i = lvDomens.SelectedIndices[0];
            lvDomens.Items.RemoveAt(i);

            CheckButtons();
        }

        private void bEditDomen_Click(object sender, EventArgs e)
        {
            if (isUsed((Domain)lvDomens.SelectedItems[0].Tag))
            {
                MessageBox.Show("Домен используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int i = lvDomens.SelectedIndices[0];
            var aed = new AddEditDomain((Domain)lvDomens.SelectedItems[0].Tag, GetNames(lvDomens));

            if (aed.ShowDialog() == DialogResult.OK)
            {
                lvDomens.Items[i] = new ListViewItem(new[] {
                    aed.Domain.Name,
                    aed.Domain.ToString()
                });
                lvDomens.Items[i].Tag = aed.Domain;
            }

            CheckButtons();
            ResizeLv(lvDomens);
        }

        private void lvDomens_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void lvVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void lvRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Close();
        }

        private void cmbGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void начатьКонсультациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbGoal.SelectedItem is null)
            {
                MessageBox.Show("Выберите целевую переменную", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lvRules.Items.Count == 0)
            {
                MessageBox.Show("Создайте хотя бы одно правило", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UpdateKBase();

            mlv = new MLV(new WorkMemory(kbase));

            DialogResult res = MessageBox.Show(cmbGoal.SelectedItem 
                + ": " 
                + mlv.GetAnswer() 
                + "\nПоказать объяснение?", 
                "Ответ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                var ef = new ExplainForm(mlv.WorkMemory);

                ef.ShowDialog();
            }
        }

        private void ResizeLv(ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ShowKBase()
        {
            lvRules.Items.Clear();
            lvVars.Items.Clear();
            lvDomens.Items.Clear();
            cmbGoal.Items.Clear();

            foreach (Domain domain in kbase.Domains)
            {
                var new_item = new ListViewItem(new[] {
                    domain.Name,
                    domain.ToString()
                });
                new_item.Tag = domain;

                lvDomens.Items.Add(new_item);
            }

            //Variable goal;

            foreach (Variable variable in kbase.Variables)
            {
                var new_item = new ListViewItem(new[] {
                    variable.Name,
                    variable.Type(),
                    variable.Domain.Name,
                    variable.Question
                });
                new_item.Tag = variable;                              

                lvVars.Items.Add(new_item);
                cmbGoal.Items.Add(variable);

                if (variable.Name == kbase.Goal.Name)
                    //goal = variable;
                    cmbGoal.SelectedItem = variable;
            }

            //cmbGoal.SelectedItem = goal;

            foreach (Rule rule in kbase.Rules)
            {
                var new_item = new ListViewItem(new[] {
                        rule.Name,
                        rule.ToString(),
                        rule.Reason
                    });
                new_item.Tag = rule;

                lvRules.Items.Add(new_item);
            }

            ResizeLv(lvRules);
            ResizeLv(lvVars);
            ResizeLv(lvDomens);
        }

        XmlSerializer xs = new XmlSerializer(typeof(KBase));

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "KB Files (*.kb)|*.kb";
            //ofd.DefaultExt = "json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(ofd.FileName);
                kbase = JsonSerializer.Deserialize<KBase>(jsonString);
                ShowKBase();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateKBase();

            string jsonString = JsonSerializer.Serialize(kbase);

            var sfd = new SaveFileDialog();
            sfd.Filter = "KB Files (*.kb)|*.kb";
            sfd.DefaultExt = "kb";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, jsonString);
            }
        }

        private void получитьОбъяснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ef = new ExplainForm(mlv.WorkMemory);

            ef.ShowDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //ResizeLv(lvRules);
            //ResizeLv(lvVars);
            //ResizeLv(lvDomens);
        }
    }
}
