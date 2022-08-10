
namespace щищ
{
    partial class AddEditDomain
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAddValue = new System.Windows.Forms.Button();
            this.bDeleteValue = new System.Windows.Forms.Button();
            this.bEditValue = new System.Windows.Forms.Button();
            this.lbValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя домена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значения";
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(56, 230);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 4;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(137, 230);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAddValue
            // 
            this.bAddValue.Location = new System.Drawing.Point(13, 196);
            this.bAddValue.Name = "bAddValue";
            this.bAddValue.Size = new System.Drawing.Size(67, 23);
            this.bAddValue.TabIndex = 6;
            this.bAddValue.Text = "➕";
            this.bAddValue.UseVisualStyleBackColor = true;
            this.bAddValue.Click += new System.EventHandler(this.bAddValue_Click);
            // 
            // bDeleteValue
            // 
            this.bDeleteValue.Location = new System.Drawing.Point(100, 196);
            this.bDeleteValue.Name = "bDeleteValue";
            this.bDeleteValue.Size = new System.Drawing.Size(67, 23);
            this.bDeleteValue.TabIndex = 7;
            this.bDeleteValue.Text = "➖";
            this.bDeleteValue.UseVisualStyleBackColor = true;
            this.bDeleteValue.Click += new System.EventHandler(this.bDeleteValue_Click);
            // 
            // bEditValue
            // 
            this.bEditValue.Location = new System.Drawing.Point(187, 196);
            this.bEditValue.Name = "bEditValue";
            this.bEditValue.Size = new System.Drawing.Size(67, 23);
            this.bEditValue.TabIndex = 8;
            this.bEditValue.Text = "✎";
            this.bEditValue.UseVisualStyleBackColor = true;
            this.bEditValue.Click += new System.EventHandler(this.bEditValue_Click);
            // 
            // lbValues
            // 
            this.lbValues.FormattingEnabled = true;
            this.lbValues.Location = new System.Drawing.Point(11, 69);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(243, 121);
            this.lbValues.TabIndex = 9;
            this.lbValues.SelectedIndexChanged += new System.EventHandler(this.lbValues_SelectedIndexChanged);
            // 
            // AddEditDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 266);
            this.Controls.Add(this.lbValues);
            this.Controls.Add(this.bEditValue);
            this.Controls.Add(this.bDeleteValue);
            this.Controls.Add(this.bAddValue);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditDomain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddEditDomain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAddValue;
        private System.Windows.Forms.Button bDeleteValue;
        private System.Windows.Forms.Button bEditValue;
        private System.Windows.Forms.ListBox lbValues;
    }
}