
namespace щищ
{
    partial class AddEditVar
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cmbDomain = new System.Windows.Forms.ComboBox();
            this.bAddDomain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(169, 179);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 14;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(88, 179);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 13;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Домен";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя переменной";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(308, 20);
            this.tbName.TabIndex = 9;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // cmbDomain
            // 
            this.cmbDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDomain.FormattingEnabled = true;
            this.cmbDomain.Location = new System.Drawing.Point(13, 151);
            this.cmbDomain.Name = "cmbDomain";
            this.cmbDomain.Size = new System.Drawing.Size(271, 21);
            this.cmbDomain.TabIndex = 16;
            this.cmbDomain.SelectedIndexChanged += new System.EventHandler(this.cmbDomain_SelectedIndexChanged);
            // 
            // bAddDomain
            // 
            this.bAddDomain.Location = new System.Drawing.Point(290, 149);
            this.bAddDomain.Name = "bAddDomain";
            this.bAddDomain.Size = new System.Drawing.Size(31, 23);
            this.bAddDomain.TabIndex = 17;
            this.bAddDomain.Text = "➕";
            this.bAddDomain.UseVisualStyleBackColor = true;
            this.bAddDomain.Click += new System.EventHandler(this.bAddDomain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Тип";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(13, 66);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(108, 17);
            this.rb1.TabIndex = 19;
            this.rb1.TabStop = true;
            this.rb1.Text = "Запрашиваемая";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(13, 89);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(84, 17);
            this.rb2.TabIndex = 20;
            this.rb2.TabStop = true;
            this.rb2.Text = "Выводимая";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(13, 112);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(163, 17);
            this.rb3.TabIndex = 21;
            this.rb3.TabStop = true;
            this.rb3.Text = "Запрашиваемо-выводимая";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // AddEditVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 211);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAddDomain);
            this.Controls.Add(this.cmbDomain);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditVar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddEditVar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cmbDomain;
        private System.Windows.Forms.Button bAddDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
    }
}