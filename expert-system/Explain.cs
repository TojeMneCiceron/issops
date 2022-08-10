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
    public partial class ExplainForm : Form
    {
        public ExplainForm(WorkMemory wm)
        {
            InitializeComponent();
            InitializeTreeView(new List<TRule>(wm.TriggeredRules));
            InitializeLV(wm.Facts);
        }

        private void InitializeLV(Dictionary<string, Fact> facts)
        {
            foreach (Fact f in facts.Values)
            {
                lvFacts.Items.Add(new ListViewItem(new[] {
                    f.Variable.Name,
                    f.Value.Name
                }));
            }

            lvFacts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvFacts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void InitializeTreeView(List<TRule> tr)
        {
            if (tr.Count == 0)
                return;

            tr.Reverse();

            Stack<TreeNode> stack = new Stack<TreeNode>();

            TreeNode lastNode = new TreeNode();

            for (int i = 0; i < tr.Count; i++)
            {
                TreeNode node;

                var temp = tr[i].ToString().Split('\n');

                node = new TreeNode(temp[0]);

                //if (tr[i].Rule != null)
                //    node.Nodes.Add(tr[i].Rule.Name);

                for (int j = 1; j < temp.Length; j++)
                    node.Nodes.Add(temp[j]);

                if (tr[i].Level == 0)
                    tv.Nodes.Add(node);
                else
                {
                    if (tr[i].Level > tr[i - 1].Level)
                        stack.Push(lastNode);

                    if (i > 0 && tr[i].Level < tr[i - 1].Level)
                        for (int j = tr[i].Level; j < tr[i - 1].Level; j++)
                            stack.Pop();

                    TreeNode parent = stack.Peek();
                    parent.Nodes.Add(node);
                }

                lastNode = node;
            }
        }

        private void llbShowHideAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (llbShowHideAll.Text)
            {
                case "(показать все)":
                    llbShowHideAll.Text = "(скрыть все)";
                    tv.ExpandAll();
                    break;

                case "(скрыть все)":
                    llbShowHideAll.Text = "(показать все)";
                    tv.CollapseAll();
                    break;
                default: break;
            }

        }
    }
}
