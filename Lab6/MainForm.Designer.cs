namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxWheels = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diameterRadioButton = new System.Windows.Forms.RadioButton();
            this.widthRadioButton = new System.Windows.Forms.RadioButton();
            this.rimRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxWheels
            // 
            this.listBoxWheels.FormattingEnabled = true;
            this.listBoxWheels.ItemHeight = 15;
            this.listBoxWheels.Location = new System.Drawing.Point(12, 27);
            this.listBoxWheels.Name = "listBoxWheels";
            this.listBoxWheels.Size = new System.Drawing.Size(206, 199);
            this.listBoxWheels.TabIndex = 1;
            this.listBoxWheels.SelectedIndexChanged += new System.EventHandler(this.listBoxWheels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список &элементов";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(224, 115);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(162, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "&Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(308, 144);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(78, 23);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "&Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Enabled = false;
            this.buttonModify.Location = new System.Drawing.Point(224, 144);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(78, 23);
            this.buttonModify.TabIndex = 7;
            this.buttonModify.Text = "&Изменить";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diameterRadioButton);
            this.groupBox1.Controls.Add(this.widthRadioButton);
            this.groupBox1.Controls.Add(this.rimRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить по...";
            // 
            // diameterRadioButton
            // 
            this.diameterRadioButton.AutoSize = true;
            this.diameterRadioButton.Location = new System.Drawing.Point(6, 72);
            this.diameterRadioButton.Name = "diameterRadioButton";
            this.diameterRadioButton.Size = new System.Drawing.Size(77, 19);
            this.diameterRadioButton.TabIndex = 5;
            this.diameterRadioButton.TabStop = true;
            this.diameterRadioButton.Text = "диаметру";
            this.diameterRadioButton.UseVisualStyleBackColor = true;
            // 
            // widthRadioButton
            // 
            this.widthRadioButton.AutoSize = true;
            this.widthRadioButton.Location = new System.Drawing.Point(6, 47);
            this.widthRadioButton.Name = "widthRadioButton";
            this.widthRadioButton.Size = new System.Drawing.Size(70, 19);
            this.widthRadioButton.TabIndex = 4;
            this.widthRadioButton.TabStop = true;
            this.widthRadioButton.Text = "ширине";
            this.widthRadioButton.UseVisualStyleBackColor = true;
            // 
            // rimRadioButton
            // 
            this.rimRadioButton.AutoSize = true;
            this.rimRadioButton.Location = new System.Drawing.Point(6, 22);
            this.rimRadioButton.Name = "rimRadioButton";
            this.rimRadioButton.Size = new System.Drawing.Size(56, 19);
            this.rimRadioButton.TabIndex = 3;
            this.rimRadioButton.TabStop = true;
            this.rimRadioButton.Text = "диску";
            this.rimRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Результат";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(224, 203);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(162, 23);
            this.resultTextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 234);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxWheels);
            this.Name = "MainForm";
            this.Text = "Куницин Д.С. - задание 6 - вариант 12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxWheels;
        private Label label1;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonModify;
        private GroupBox groupBox1;
        private RadioButton diameterRadioButton;
        private RadioButton widthRadioButton;
        private RadioButton rimRadioButton;
        private Label label2;
        private TextBox resultTextBox;
    }
}