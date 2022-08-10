
namespace щищ
{
    partial class ExplainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tv = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lvFacts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.llbShowHideAll = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv.ItemHeight = 16;
            this.tv.Location = new System.Drawing.Point(12, 25);
            this.tv.Name = "tv";
            this.tv.ShowLines = false;
            this.tv.Size = new System.Drawing.Size(364, 296);
            this.tv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Правила";
            // 
            // lvFacts
            // 
            this.lvFacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvFacts.FullRowSelect = true;
            this.lvFacts.GridLines = true;
            this.lvFacts.HideSelection = false;
            this.lvFacts.Location = new System.Drawing.Point(380, 25);
            this.lvFacts.Name = "lvFacts";
            this.lvFacts.Size = new System.Drawing.Size(364, 296);
            this.lvFacts.TabIndex = 2;
            this.lvFacts.UseCompatibleStateImageBehavior = false;
            this.lvFacts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Переменные";
            // 
            // llbShowHideAll
            // 
            this.llbShowHideAll.AutoSize = true;
            this.llbShowHideAll.Location = new System.Drawing.Point(61, 9);
            this.llbShowHideAll.Name = "llbShowHideAll";
            this.llbShowHideAll.Size = new System.Drawing.Size(81, 13);
            this.llbShowHideAll.TabIndex = 4;
            this.llbShowHideAll.TabStop = true;
            this.llbShowHideAll.Text = "(показать все)";
            this.llbShowHideAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowHideAll_LinkClicked);
            // 
            // ExplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 333);
            this.Controls.Add(this.llbShowHideAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvFacts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tv);
            this.Name = "ExplainForm";
            this.Text = "Объяснение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvFacts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbShowHideAll;
    }
}