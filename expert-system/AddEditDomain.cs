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
    public partial class AddEditDomain : Form
    {
        Domain domain;
        List<string> existingNames;

        public AddEditDomain(Domain domain, List<string> names)
        {
            InitializeComponent();

            this.Domain = domain;
            existingNames = names;


            if (domain is null)
                tbName.Text = NewName();
            else
            {
                tbName.Text = domain.Name;
                foreach (Value value in domain.Values)
                    lbValues.Items.Add(value);
            }

            CheckButtons();
            SetDragDrop();
        }

        internal Domain Domain { get => domain; set => domain = value; }

        private void SetDragDrop()
        {
            lbValues.AllowDrop = true;
            lbValues.DragDrop += new DragEventHandler(lbValues_DragDrop);
            lbValues.MouseDown += new MouseEventHandler(lbValues_MouseDown);
            lbValues.DragOver += new DragEventHandler(lbValues_DragOver);
        }

        private void lbValues_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbValues.SelectedItem == null) return;
            CheckButtons();
            lbValues.DoDragDrop(lbValues.SelectedItem, DragDropEffects.Move);
        }

        private void lbValues_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lbValues_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lbValues.PointToClient(new Point(e.X, e.Y));
            int index = lbValues.IndexFromPoint(point);
            if (index < 0) index = lbValues.Items.Count - 1;
            object data = lbValues.SelectedItem;
            lbValues.Items.Remove(data);
            lbValues.Items.Insert(index, data);
        }


        private string NewName()
        {
            if (existingNames.Count == 0)
                return "Domain1";

            var temp = existingNames.Where(x => new Regex(@"^Domain[0-9]+$").IsMatch(x)).ToList();

            if (temp.Count == 0)
                return "Domain" + (existingNames.Count + 1).ToString();
            else
            {
                int a = temp.Select(x => int.Parse(x.Substring(6))).Max();

                a = Math.Max(a, existingNames.Count) + 1;
                return "Domain" + a.ToString();
            }
        }
        private void CheckButtons()
        {
            bOk.Enabled = !(tbName.Text == "" || lbValues.Items.Count == 0);

            bDeleteValue.Enabled = bEditValue.Enabled = !(lbValues.SelectedItem is null);
        }

        private bool CheckName()
        {
            string name = tbName.Text.Trim();
            if (existingNames.Contains(name))
                return domain != null && name == domain.Name;

            return true;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (!CheckName())
            {
                MessageBox.Show("Домен с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Value> values = new List<Value>();
            foreach (Value value in lbValues.Items)
                values.Add(value);

            domain = new Domain(tbName.Text, values);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bAddValue_Click(object sender, EventArgs e)
        {
            var av = new Input("");

            if (av.ShowDialog() == DialogResult.OK)
                lbValues.Items.Add(new Value(av.Result));

            CheckButtons();
        }

        private void bDeleteValue_Click(object sender, EventArgs e)
        {
            lbValues.Items.Remove(lbValues.SelectedItem);
            CheckButtons();
        }

        private void bEditValue_Click(object sender, EventArgs e)
        {
            var av = new Input(((Value)lbValues.SelectedItem).Name);

            if (av.ShowDialog() == DialogResult.OK)
            {
                int i = lbValues.SelectedIndex;
                lbValues.Items.RemoveAt(i);
                lbValues.Items.Insert(i, new Value(av.Result));
            }


            //mb update listbox

            CheckButtons();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void lbValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }
    }
}
