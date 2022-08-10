
namespace щищ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьКонсультациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьОбъяснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bEditRule = new System.Windows.Forms.Button();
            this.bDeleteRule = new System.Windows.Forms.Button();
            this.bAddRule = new System.Windows.Forms.Button();
            this.lvRules = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bEditVar = new System.Windows.Forms.Button();
            this.bDeleteVar = new System.Windows.Forms.Button();
            this.bAddVar = new System.Windows.Forms.Button();
            this.lvVars = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEditDomen = new System.Windows.Forms.Button();
            this.bDeleteDomen = new System.Windows.Forms.Button();
            this.bAddDomen = new System.Windows.Forms.Button();
            this.lvDomens = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGoal = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.консультацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // консультацияToolStripMenuItem
            // 
            this.консультацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьКонсультациюToolStripMenuItem,
            this.получитьОбъяснениеToolStripMenuItem});
            this.консультацияToolStripMenuItem.Name = "консультацияToolStripMenuItem";
            this.консультацияToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.консультацияToolStripMenuItem.Text = "Консультация";
            // 
            // начатьКонсультациюToolStripMenuItem
            // 
            this.начатьКонсультациюToolStripMenuItem.Name = "начатьКонсультациюToolStripMenuItem";
            this.начатьКонсультациюToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.начатьКонсультациюToolStripMenuItem.Text = "Начать консультацию";
            this.начатьКонсультациюToolStripMenuItem.Click += new System.EventHandler(this.начатьКонсультациюToolStripMenuItem_Click);
            // 
            // получитьОбъяснениеToolStripMenuItem
            // 
            this.получитьОбъяснениеToolStripMenuItem.Name = "получитьОбъяснениеToolStripMenuItem";
            this.получитьОбъяснениеToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.получитьОбъяснениеToolStripMenuItem.Text = "Получить объяснение";
            this.получитьОбъяснениеToolStripMenuItem.Click += new System.EventHandler(this.получитьОбъяснениеToolStripMenuItem_Click);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Controls.Add(this.tabPage2);
            this.tabCtrl.Controls.Add(this.tabPage3);
            this.tabCtrl.Location = new System.Drawing.Point(0, 30);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(800, 420);
            this.tabCtrl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.lvRules);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Правила";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bEditRule);
            this.groupBox3.Controls.Add(this.bDeleteRule);
            this.groupBox3.Controls.Add(this.bAddRule);
            this.groupBox3.Location = new System.Drawing.Point(740, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(44, 97);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // bEditRule
            // 
            this.bEditRule.Location = new System.Drawing.Point(6, 68);
            this.bEditRule.Name = "bEditRule";
            this.bEditRule.Size = new System.Drawing.Size(31, 23);
            this.bEditRule.TabIndex = 2;
            this.bEditRule.Text = "✎";
            this.bEditRule.UseVisualStyleBackColor = true;
            this.bEditRule.Click += new System.EventHandler(this.bEditRule_Click);
            // 
            // bDeleteRule
            // 
            this.bDeleteRule.Location = new System.Drawing.Point(5, 39);
            this.bDeleteRule.Name = "bDeleteRule";
            this.bDeleteRule.Size = new System.Drawing.Size(32, 23);
            this.bDeleteRule.TabIndex = 1;
            this.bDeleteRule.Text = "➖";
            this.bDeleteRule.UseVisualStyleBackColor = true;
            this.bDeleteRule.Click += new System.EventHandler(this.bDeleteRule_Click);
            // 
            // bAddRule
            // 
            this.bAddRule.Location = new System.Drawing.Point(6, 10);
            this.bAddRule.Name = "bAddRule";
            this.bAddRule.Size = new System.Drawing.Size(31, 23);
            this.bAddRule.TabIndex = 0;
            this.bAddRule.Text = "➕";
            this.bAddRule.UseVisualStyleBackColor = true;
            this.bAddRule.Click += new System.EventHandler(this.bAddRule_Click);
            // 
            // lvRules
            // 
            this.lvRules.AllowDrop = true;
            this.lvRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9});
            this.lvRules.FullRowSelect = true;
            this.lvRules.GridLines = true;
            this.lvRules.HideSelection = false;
            this.lvRules.Location = new System.Drawing.Point(3, 3);
            this.lvRules.MultiSelect = false;
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(731, 388);
            this.lvRules.TabIndex = 3;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.View = System.Windows.Forms.View.Details;
            this.lvRules.SelectedIndexChanged += new System.EventHandler(this.lvRules_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Имя";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Описание";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Пояснение";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lvVars);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Переменные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bEditVar);
            this.groupBox2.Controls.Add(this.bDeleteVar);
            this.groupBox2.Controls.Add(this.bAddVar);
            this.groupBox2.Location = new System.Drawing.Point(740, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(44, 97);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // bEditVar
            // 
            this.bEditVar.Location = new System.Drawing.Point(6, 68);
            this.bEditVar.Name = "bEditVar";
            this.bEditVar.Size = new System.Drawing.Size(31, 23);
            this.bEditVar.TabIndex = 2;
            this.bEditVar.Text = "✎";
            this.bEditVar.UseVisualStyleBackColor = true;
            this.bEditVar.Click += new System.EventHandler(this.bEditVar_Click);
            // 
            // bDeleteVar
            // 
            this.bDeleteVar.Location = new System.Drawing.Point(5, 39);
            this.bDeleteVar.Name = "bDeleteVar";
            this.bDeleteVar.Size = new System.Drawing.Size(32, 23);
            this.bDeleteVar.TabIndex = 1;
            this.bDeleteVar.Text = "➖";
            this.bDeleteVar.UseVisualStyleBackColor = true;
            this.bDeleteVar.Click += new System.EventHandler(this.bDeleteVar_Click);
            // 
            // bAddVar
            // 
            this.bAddVar.Location = new System.Drawing.Point(6, 10);
            this.bAddVar.Name = "bAddVar";
            this.bAddVar.Size = new System.Drawing.Size(31, 23);
            this.bAddVar.TabIndex = 0;
            this.bAddVar.Text = "➕";
            this.bAddVar.UseVisualStyleBackColor = true;
            this.bAddVar.Click += new System.EventHandler(this.bAddVar_Click);
            // 
            // lvVars
            // 
            this.lvVars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8});
            this.lvVars.FullRowSelect = true;
            this.lvVars.GridLines = true;
            this.lvVars.HideSelection = false;
            this.lvVars.Location = new System.Drawing.Point(3, 3);
            this.lvVars.MultiSelect = false;
            this.lvVars.Name = "lvVars";
            this.lvVars.Size = new System.Drawing.Size(731, 388);
            this.lvVars.TabIndex = 3;
            this.lvVars.UseCompatibleStateImageBehavior = false;
            this.lvVars.View = System.Windows.Forms.View.Details;
            this.lvVars.SelectedIndexChanged += new System.EventHandler(this.lvVars_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Домен";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Вопрос";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.lvDomens);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Домены";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bEditDomen);
            this.groupBox1.Controls.Add(this.bDeleteDomen);
            this.groupBox1.Controls.Add(this.bAddDomen);
            this.groupBox1.Location = new System.Drawing.Point(740, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(44, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bEditDomen
            // 
            this.bEditDomen.Location = new System.Drawing.Point(6, 68);
            this.bEditDomen.Name = "bEditDomen";
            this.bEditDomen.Size = new System.Drawing.Size(31, 23);
            this.bEditDomen.TabIndex = 2;
            this.bEditDomen.Text = "✎";
            this.bEditDomen.UseVisualStyleBackColor = true;
            this.bEditDomen.Click += new System.EventHandler(this.bEditDomen_Click);
            // 
            // bDeleteDomen
            // 
            this.bDeleteDomen.Location = new System.Drawing.Point(5, 39);
            this.bDeleteDomen.Name = "bDeleteDomen";
            this.bDeleteDomen.Size = new System.Drawing.Size(32, 23);
            this.bDeleteDomen.TabIndex = 1;
            this.bDeleteDomen.Text = "➖";
            this.bDeleteDomen.UseVisualStyleBackColor = true;
            this.bDeleteDomen.Click += new System.EventHandler(this.bDeleteDomen_Click);
            // 
            // bAddDomen
            // 
            this.bAddDomen.Location = new System.Drawing.Point(6, 10);
            this.bAddDomen.Name = "bAddDomen";
            this.bAddDomen.Size = new System.Drawing.Size(31, 23);
            this.bAddDomen.TabIndex = 0;
            this.bAddDomen.Text = "➕";
            this.bAddDomen.UseVisualStyleBackColor = true;
            this.bAddDomen.Click += new System.EventHandler(this.bAddDomen_Click);
            // 
            // lvDomens
            // 
            this.lvDomens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDomens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7});
            this.lvDomens.FullRowSelect = true;
            this.lvDomens.GridLines = true;
            this.lvDomens.HideSelection = false;
            this.lvDomens.Location = new System.Drawing.Point(3, 3);
            this.lvDomens.MultiSelect = false;
            this.lvDomens.Name = "lvDomens";
            this.lvDomens.Size = new System.Drawing.Size(731, 388);
            this.lvDomens.TabIndex = 0;
            this.lvDomens.UseCompatibleStateImageBehavior = false;
            this.lvDomens.View = System.Windows.Forms.View.Details;
            this.lvDomens.SelectedIndexChanged += new System.EventHandler(this.lvDomens_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Значения";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Целевая переменная";
            // 
            // cmbGoal
            // 
            this.cmbGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGoal.BackColor = System.Drawing.Color.White;
            this.cmbGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoal.FormattingEnabled = true;
            this.cmbGoal.Location = new System.Drawing.Point(602, 27);
            this.cmbGoal.Name = "cmbGoal";
            this.cmbGoal.Size = new System.Drawing.Size(186, 21);
            this.cmbGoal.TabIndex = 3;
            this.cmbGoal.SelectedIndexChanged += new System.EventHandler(this.cmbGoal_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGoal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "долар";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvDomens;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEditDomen;
        private System.Windows.Forms.Button bDeleteDomen;
        private System.Windows.Forms.Button bAddDomen;
        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvVars;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bDeleteRule;
        private System.Windows.Forms.Button bAddRule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bEditVar;
        private System.Windows.Forms.Button bDeleteVar;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGoal;
        private System.Windows.Forms.Button bEditRule;
        private System.Windows.Forms.Button bAddVar;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьКонсультациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьОбъяснениеToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

