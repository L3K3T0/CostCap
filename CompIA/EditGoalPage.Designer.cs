namespace CompIA
{
    partial class EditGoalPage
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
            this.CategoryLab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.goalNameLab = new System.Windows.Forms.Label();
            this.goalNameInp = new System.Windows.Forms.TextBox();
            this.savAmtInp = new System.Windows.Forms.TextBox();
            this.savAmtLab = new System.Windows.Forms.Label();
            this.dueDateLab = new System.Windows.Forms.Label();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.goalTypeCombo = new System.Windows.Forms.ComboBox();
            this.goalTypeLab = new System.Windows.Forms.Label();
            this.PrioInp = new System.Windows.Forms.TextBox();
            this.priorityLab = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amtCompInp = new System.Windows.Forms.TextBox();
            this.amtCompLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompleteBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryLab
            // 
            this.CategoryLab.AutoSize = true;
            this.CategoryLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLab.Location = new System.Drawing.Point(41, 62);
            this.CategoryLab.Name = "CategoryLab";
            this.CategoryLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryLab.Size = new System.Drawing.Size(84, 22);
            this.CategoryLab.TabIndex = 1;
            this.CategoryLab.Text = "Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CompIA.Properties.Resources.Close_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(45, 87);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(193, 21);
            this.categoryCombo.TabIndex = 3;
            // 
            // goalNameLab
            // 
            this.goalNameLab.AutoSize = true;
            this.goalNameLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalNameLab.Location = new System.Drawing.Point(41, 142);
            this.goalNameLab.Name = "goalNameLab";
            this.goalNameLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.goalNameLab.Size = new System.Drawing.Size(100, 22);
            this.goalNameLab.TabIndex = 4;
            this.goalNameLab.Text = "Goal Name";
            // 
            // goalNameInp
            // 
            this.goalNameInp.Location = new System.Drawing.Point(45, 167);
            this.goalNameInp.Name = "goalNameInp";
            this.goalNameInp.Size = new System.Drawing.Size(193, 20);
            this.goalNameInp.TabIndex = 5;
            // 
            // savAmtInp
            // 
            this.savAmtInp.Location = new System.Drawing.Point(45, 250);
            this.savAmtInp.Name = "savAmtInp";
            this.savAmtInp.Size = new System.Drawing.Size(193, 20);
            this.savAmtInp.TabIndex = 7;
            // 
            // savAmtLab
            // 
            this.savAmtLab.AutoSize = true;
            this.savAmtLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savAmtLab.Location = new System.Drawing.Point(41, 225);
            this.savAmtLab.Name = "savAmtLab";
            this.savAmtLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.savAmtLab.Size = new System.Drawing.Size(135, 22);
            this.savAmtLab.TabIndex = 6;
            this.savAmtLab.Text = "Saving Amount";
            // 
            // dueDateLab
            // 
            this.dueDateLab.AutoSize = true;
            this.dueDateLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLab.Location = new System.Drawing.Point(41, 345);
            this.dueDateLab.Name = "dueDateLab";
            this.dueDateLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dueDateLab.Size = new System.Drawing.Size(85, 22);
            this.dueDateLab.TabIndex = 8;
            this.dueDateLab.Text = "Due Date";
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(45, 370);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDatePicker.TabIndex = 10;
            // 
            // goalTypeCombo
            // 
            this.goalTypeCombo.FormattingEnabled = true;
            this.goalTypeCombo.Items.AddRange(new object[] {
            "Saving Goal",
            "Budgeting Goal"});
            this.goalTypeCombo.Location = new System.Drawing.Point(45, 449);
            this.goalTypeCombo.Name = "goalTypeCombo";
            this.goalTypeCombo.Size = new System.Drawing.Size(193, 21);
            this.goalTypeCombo.TabIndex = 11;
            // 
            // goalTypeLab
            // 
            this.goalTypeLab.AutoSize = true;
            this.goalTypeLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalTypeLab.Location = new System.Drawing.Point(41, 424);
            this.goalTypeLab.Name = "goalTypeLab";
            this.goalTypeLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.goalTypeLab.Size = new System.Drawing.Size(115, 22);
            this.goalTypeLab.TabIndex = 12;
            this.goalTypeLab.Text = "Type Of Goal";
            // 
            // PrioInp
            // 
            this.PrioInp.Location = new System.Drawing.Point(45, 513);
            this.PrioInp.Name = "PrioInp";
            this.PrioInp.Size = new System.Drawing.Size(100, 20);
            this.PrioInp.TabIndex = 13;
            // 
            // priorityLab
            // 
            this.priorityLab.AutoSize = true;
            this.priorityLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLab.Location = new System.Drawing.Point(41, 488);
            this.priorityLab.Name = "priorityLab";
            this.priorityLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priorityLab.Size = new System.Drawing.Size(72, 22);
            this.priorityLab.TabIndex = 14;
            this.priorityLab.Text = "Priority";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(81)))));
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(26, 597);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(498, 47);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Confirm Changes";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.confirmButton_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 250);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "(Give without the \'£\' symbol)\r\nCannot be 0!";
            // 
            // amtCompInp
            // 
            this.amtCompInp.Location = new System.Drawing.Point(45, 309);
            this.amtCompInp.Name = "amtCompInp";
            this.amtCompInp.Size = new System.Drawing.Size(193, 20);
            this.amtCompInp.TabIndex = 18;
            // 
            // amtCompLab
            // 
            this.amtCompLab.AutoSize = true;
            this.amtCompLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtCompLab.Location = new System.Drawing.Point(41, 284);
            this.amtCompLab.Name = "amtCompLab";
            this.amtCompLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amtCompLab.Size = new System.Drawing.Size(171, 22);
            this.amtCompLab.TabIndex = 17;
            this.amtCompLab.Text = "Amount Completed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 546);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Completed?";
            // 
            // CompleteBox
            // 
            this.CompleteBox.AutoSize = true;
            this.CompleteBox.Location = new System.Drawing.Point(45, 572);
            this.CompleteBox.Name = "CompleteBox";
            this.CompleteBox.Size = new System.Drawing.Size(82, 17);
            this.CompleteBox.TabIndex = 21;
            this.CompleteBox.Text = "Completed?";
            this.CompleteBox.UseVisualStyleBackColor = true;
            // 
            // EditGoalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(559, 749);
            this.Controls.Add(this.CompleteBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amtCompInp);
            this.Controls.Add(this.amtCompLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.priorityLab);
            this.Controls.Add(this.PrioInp);
            this.Controls.Add(this.goalTypeLab);
            this.Controls.Add(this.goalTypeCombo);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.dueDateLab);
            this.Controls.Add(this.savAmtInp);
            this.Controls.Add(this.savAmtLab);
            this.Controls.Add(this.goalNameInp);
            this.Controls.Add(this.goalNameLab);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CategoryLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 788);
            this.MinimumSize = new System.Drawing.Size(575, 788);
            this.Name = "EditGoalPage";
            this.Text = "EditGoalPage";
            this.Load += new System.EventHandler(this.EditGoalPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CategoryLab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label goalNameLab;
        private System.Windows.Forms.TextBox goalNameInp;
        private System.Windows.Forms.TextBox savAmtInp;
        private System.Windows.Forms.Label savAmtLab;
        private System.Windows.Forms.Label dueDateLab;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.ComboBox goalTypeCombo;
        private System.Windows.Forms.Label goalTypeLab;
        private System.Windows.Forms.TextBox PrioInp;
        private System.Windows.Forms.Label priorityLab;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amtCompInp;
        private System.Windows.Forms.Label amtCompLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CompleteBox;
    }
}