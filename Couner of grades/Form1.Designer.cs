namespace Couner_of_grades
{
    partial class FormGrade
    {
        private string BufferGrades = null;

        private float Middle        = 0;

        private byte Count          = 0;

        private byte[] Grades       = new byte[32];

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrade));
            this.StartCountButton = new System.Windows.Forms.Button();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianLanguageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.englishLanguageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BoxOfShowingGrades = new System.Windows.Forms.TextBox();
            this.WriteGradeInBase = new System.Windows.Forms.Button();
            this.middleGradeNowLabel = new System.Windows.Forms.Label();
            this.fiveToFour = new System.Windows.Forms.Label();
            this.fourToFour = new System.Windows.Forms.Label();
            this.GradesBox = new System.Windows.Forms.TextBox();
            this.fiveToFive = new System.Windows.Forms.Label();
            this.treeToTree = new System.Windows.Forms.Label();
            this.twoToTree = new System.Windows.Forms.Label();
            this.twoToTwo = new System.Windows.Forms.Label();
            this.Alert = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartCountButton
            // 
            this.StartCountButton.Location = new System.Drawing.Point(288, 312);
            this.StartCountButton.Name = "StartCountButton";
            this.StartCountButton.Size = new System.Drawing.Size(99, 31);
            this.StartCountButton.TabIndex = 0;
            this.StartCountButton.Text = "Count";
            this.StartCountButton.UseVisualStyleBackColor = true;
            this.StartCountButton.Click += new System.EventHandler(this.StartCountButton_Click);
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.Location = new System.Drawing.Point(12, 24);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(41, 13);
            this.HeadLabel.TabIndex = 1;
            this.HeadLabel.Text = "Grades";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.teamToolStripMenuItem.Text = "Theme";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem1.Text = "Light theme";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem2.Text = "Dark theme";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.russianLanguageMenu,
            this.englishLanguageMenu});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // russianLanguageMenu
            // 
            this.russianLanguageMenu.Name = "russianLanguageMenu";
            this.russianLanguageMenu.Size = new System.Drawing.Size(144, 22);
            this.russianLanguageMenu.Text = "Русский (Ru)";
            this.russianLanguageMenu.Click += new System.EventHandler(this.russianLanguageMenu_Click);
            // 
            // englishLanguageMenu
            // 
            this.englishLanguageMenu.Name = "englishLanguageMenu";
            this.englishLanguageMenu.Size = new System.Drawing.Size(144, 22);
            this.englishLanguageMenu.Text = "English (En)";
            this.englishLanguageMenu.Click += new System.EventHandler(this.englishLanguageMenu_Click);
            // 
            // BoxOfShowingGrades
            // 
            this.BoxOfShowingGrades.BackColor = System.Drawing.SystemColors.Menu;
            this.BoxOfShowingGrades.Location = new System.Drawing.Point(12, 40);
            this.BoxOfShowingGrades.Name = "BoxOfShowingGrades";
            this.BoxOfShowingGrades.Size = new System.Drawing.Size(305, 20);
            this.BoxOfShowingGrades.TabIndex = 3;
            // 
            // WriteGradeInBase
            // 
            this.WriteGradeInBase.Location = new System.Drawing.Point(12, 312);
            this.WriteGradeInBase.Name = "WriteGradeInBase";
            this.WriteGradeInBase.Size = new System.Drawing.Size(99, 31);
            this.WriteGradeInBase.TabIndex = 4;
            this.WriteGradeInBase.Text = "Write grade";
            this.WriteGradeInBase.UseVisualStyleBackColor = true;
            this.WriteGradeInBase.Click += new System.EventHandler(this.WriteGradeInBase_Click);
            // 
            // middleGradeNowLabel
            // 
            this.middleGradeNowLabel.AutoSize = true;
            this.middleGradeNowLabel.Location = new System.Drawing.Point(12, 154);
            this.middleGradeNowLabel.Name = "middleGradeNowLabel";
            this.middleGradeNowLabel.Size = new System.Drawing.Size(103, 13);
            this.middleGradeNowLabel.TabIndex = 5;
            this.middleGradeNowLabel.Text = "Middle grade now — ";
            // 
            // fiveToFour
            // 
            this.fiveToFour.AutoSize = true;
            this.fiveToFour.Location = new System.Drawing.Point(12, 198);
            this.fiveToFour.Name = "fiveToFour";
            this.fiveToFour.Size = new System.Drawing.Size(45, 13);
            this.fiveToFour.TabIndex = 6;
            this.fiveToFour.Text = "[5 → 4]:";
            // 
            // fourToFour
            // 
            this.fourToFour.AutoSize = true;
            this.fourToFour.Location = new System.Drawing.Point(12, 219);
            this.fourToFour.Name = "fourToFour";
            this.fourToFour.Size = new System.Drawing.Size(48, 13);
            this.fourToFour.TabIndex = 7;
            this.fourToFour.Text = "[4 → 4]: ";
            // 
            // GradesBox
            // 
            this.GradesBox.BackColor = System.Drawing.SystemColors.Menu;
            this.GradesBox.Location = new System.Drawing.Point(12, 66);
            this.GradesBox.Multiline = true;
            this.GradesBox.Name = "GradesBox";
            this.GradesBox.ReadOnly = true;
            this.GradesBox.Size = new System.Drawing.Size(305, 85);
            this.GradesBox.TabIndex = 8;
            // 
            // fiveToFive
            // 
            this.fiveToFive.AutoSize = true;
            this.fiveToFive.Location = new System.Drawing.Point(12, 176);
            this.fiveToFive.Name = "fiveToFive";
            this.fiveToFive.Size = new System.Drawing.Size(48, 13);
            this.fiveToFive.TabIndex = 9;
            this.fiveToFive.Text = "[5 → 5]: ";
            // 
            // treeToTree
            // 
            this.treeToTree.AutoSize = true;
            this.treeToTree.Location = new System.Drawing.Point(12, 242);
            this.treeToTree.Name = "treeToTree";
            this.treeToTree.Size = new System.Drawing.Size(48, 13);
            this.treeToTree.TabIndex = 10;
            this.treeToTree.Text = "[3 → 3]: ";
            // 
            // twoToTree
            // 
            this.twoToTree.AutoSize = true;
            this.twoToTree.Location = new System.Drawing.Point(12, 264);
            this.twoToTree.Name = "twoToTree";
            this.twoToTree.Size = new System.Drawing.Size(48, 13);
            this.twoToTree.TabIndex = 11;
            this.twoToTree.Text = "[2 → 3]: ";
            // 
            // twoToTwo
            // 
            this.twoToTwo.AutoSize = true;
            this.twoToTwo.Location = new System.Drawing.Point(12, 287);
            this.twoToTwo.Name = "twoToTwo";
            this.twoToTwo.Size = new System.Drawing.Size(48, 13);
            this.twoToTwo.TabIndex = 12;
            this.twoToTwo.Text = "[3 → 2]: ";
            // 
            // Alert
            // 
            this.Alert.AutoSize = true;
            this.Alert.Location = new System.Drawing.Point(318, 287);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(69, 13);
            this.Alert.TabIndex = 13;
            this.Alert.Text = "3,5 = 4 и т.д.";
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 355);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.twoToTwo);
            this.Controls.Add(this.twoToTree);
            this.Controls.Add(this.treeToTree);
            this.Controls.Add(this.fiveToFive);
            this.Controls.Add(this.GradesBox);
            this.Controls.Add(this.fourToFour);
            this.Controls.Add(this.fiveToFour);
            this.Controls.Add(this.middleGradeNowLabel);
            this.Controls.Add(this.WriteGradeInBase);
            this.Controls.Add(this.BoxOfShowingGrades);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.StartCountButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGrade";
            this.Text = "CounterOfGrades";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartCountButton;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.TextBox BoxOfShowingGrades;
        private System.Windows.Forms.Button WriteGradeInBase;
        private System.Windows.Forms.Label middleGradeNowLabel;
        private System.Windows.Forms.Label fiveToFour;
        private System.Windows.Forms.Label fourToFour;
        private System.Windows.Forms.TextBox GradesBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label fiveToFive;
        private System.Windows.Forms.Label treeToTree;
        private System.Windows.Forms.Label twoToTree;
        private System.Windows.Forms.Label twoToTwo;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianLanguageMenu;
        private System.Windows.Forms.ToolStripMenuItem englishLanguageMenu;
        private System.Windows.Forms.Label Alert;
    }
}

