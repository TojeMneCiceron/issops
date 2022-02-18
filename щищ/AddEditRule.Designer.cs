
namespace щищ
{
    partial class AddEditRule
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbConditions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbConclusions = new System.Windows.Forms.ListBox();
            this.bEditCond = new System.Windows.Forms.Button();
            this.bDeleteCond = new System.Windows.Forms.Button();
            this.bAddCond = new System.Windows.Forms.Button();
            this.bEditConc = new System.Windows.Forms.Button();
            this.bDeleteConc = new System.Windows.Forms.Button();
            this.bAddConc = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя правила";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(15, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(636, 20);
            this.tbName.TabIndex = 11;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbConditions
            // 
            this.lbConditions.FormattingEnabled = true;
            this.lbConditions.Location = new System.Drawing.Point(15, 67);
            this.lbConditions.Name = "lbConditions";
            this.lbConditions.Size = new System.Drawing.Size(310, 95);
            this.lbConditions.TabIndex = 13;
            this.lbConditions.SelectedIndexChanged += new System.EventHandler(this.lbConditions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Посылка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Заключение";
            // 
            // lbConclusions
            // 
            this.lbConclusions.FormattingEnabled = true;
            this.lbConclusions.Location = new System.Drawing.Point(341, 67);
            this.lbConclusions.Name = "lbConclusions";
            this.lbConclusions.Size = new System.Drawing.Size(310, 95);
            this.lbConclusions.TabIndex = 16;
            this.lbConclusions.SelectedIndexChanged += new System.EventHandler(this.lbConclusions_SelectedIndexChanged);
            // 
            // bEditCond
            // 
            this.bEditCond.Location = new System.Drawing.Point(241, 168);
            this.bEditCond.Name = "bEditCond";
            this.bEditCond.Size = new System.Drawing.Size(84, 23);
            this.bEditCond.TabIndex = 20;
            this.bEditCond.Text = "✎";
            this.bEditCond.UseVisualStyleBackColor = true;
            this.bEditCond.Click += new System.EventHandler(this.bEditCond_Click);
            // 
            // bDeleteCond
            // 
            this.bDeleteCond.Location = new System.Drawing.Point(128, 168);
            this.bDeleteCond.Name = "bDeleteCond";
            this.bDeleteCond.Size = new System.Drawing.Size(84, 23);
            this.bDeleteCond.TabIndex = 19;
            this.bDeleteCond.Text = "➖";
            this.bDeleteCond.UseVisualStyleBackColor = true;
            this.bDeleteCond.Click += new System.EventHandler(this.bDeleteCond_Click);
            // 
            // bAddCond
            // 
            this.bAddCond.Location = new System.Drawing.Point(15, 168);
            this.bAddCond.Name = "bAddCond";
            this.bAddCond.Size = new System.Drawing.Size(84, 23);
            this.bAddCond.TabIndex = 18;
            this.bAddCond.Text = "➕";
            this.bAddCond.UseVisualStyleBackColor = true;
            this.bAddCond.Click += new System.EventHandler(this.bAddCond_Click);
            // 
            // bEditConc
            // 
            this.bEditConc.Location = new System.Drawing.Point(567, 168);
            this.bEditConc.Name = "bEditConc";
            this.bEditConc.Size = new System.Drawing.Size(84, 23);
            this.bEditConc.TabIndex = 23;
            this.bEditConc.Text = "✎";
            this.bEditConc.UseVisualStyleBackColor = true;
            this.bEditConc.Click += new System.EventHandler(this.bEditConc_Click);
            // 
            // bDeleteConc
            // 
            this.bDeleteConc.Location = new System.Drawing.Point(454, 168);
            this.bDeleteConc.Name = "bDeleteConc";
            this.bDeleteConc.Size = new System.Drawing.Size(84, 23);
            this.bDeleteConc.TabIndex = 22;
            this.bDeleteConc.Text = "➖";
            this.bDeleteConc.UseVisualStyleBackColor = true;
            this.bDeleteConc.Click += new System.EventHandler(this.bDeleteConc_Click);
            // 
            // bAddConc
            // 
            this.bAddConc.Location = new System.Drawing.Point(341, 168);
            this.bAddConc.Name = "bAddConc";
            this.bAddConc.Size = new System.Drawing.Size(84, 23);
            this.bAddConc.TabIndex = 21;
            this.bAddConc.Text = "➕";
            this.bAddConc.UseVisualStyleBackColor = true;
            this.bAddConc.Click += new System.EventHandler(this.bAddConc_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(334, 275);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 25;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(253, 275);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 24;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Пояснение";
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(14, 215);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(637, 54);
            this.tbReason.TabIndex = 26;
            this.tbReason.TextChanged += new System.EventHandler(this.tbReason_TextChanged);
            // 
            // AddEditRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bEditConc);
            this.Controls.Add(this.bDeleteConc);
            this.Controls.Add(this.bAddConc);
            this.Controls.Add(this.bEditCond);
            this.Controls.Add(this.bDeleteCond);
            this.Controls.Add(this.bAddCond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbConclusions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbConditions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditRule";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddEditRule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbConditions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbConclusions;
        private System.Windows.Forms.Button bEditCond;
        private System.Windows.Forms.Button bDeleteCond;
        private System.Windows.Forms.Button bAddCond;
        private System.Windows.Forms.Button bEditConc;
        private System.Windows.Forms.Button bDeleteConc;
        private System.Windows.Forms.Button bAddConc;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReason;
    }
}