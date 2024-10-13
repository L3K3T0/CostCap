namespace CompIA
{
    partial class EditPaymentsPage
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
            this.CompleteBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goalTypeLab = new System.Windows.Forms.Label();
            this.paymentTypeCombo = new System.Windows.Forms.ComboBox();
            this.billingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.billingDateLab = new System.Windows.Forms.Label();
            this.paymentAmtInp = new System.Windows.Forms.TextBox();
            this.paymentAmtLab = new System.Windows.Forms.Label();
            this.paymentNameInp = new System.Windows.Forms.TextBox();
            this.paymentNameLab = new System.Windows.Forms.Label();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.CategoryLab = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompleteBox
            // 
            this.CompleteBox.AutoSize = true;
            this.CompleteBox.Location = new System.Drawing.Point(48, 562);
            this.CompleteBox.Name = "CompleteBox";
            this.CompleteBox.Size = new System.Drawing.Size(82, 17);
            this.CompleteBox.TabIndex = 33;
            this.CompleteBox.Text = "Completed?";
            this.CompleteBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 536);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Completed?";
            // 
            // goalTypeLab
            // 
            this.goalTypeLab.AutoSize = true;
            this.goalTypeLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalTypeLab.Location = new System.Drawing.Point(44, 414);
            this.goalTypeLab.Name = "goalTypeLab";
            this.goalTypeLab.Size = new System.Drawing.Size(147, 22);
            this.goalTypeLab.TabIndex = 31;
            this.goalTypeLab.Text = "Type of Payment";
            // 
            // paymentTypeCombo
            // 
            this.paymentTypeCombo.FormattingEnabled = true;
            this.paymentTypeCombo.Items.AddRange(new object[] {
            "Subscription",
            "One-time "});
            this.paymentTypeCombo.Location = new System.Drawing.Point(48, 439);
            this.paymentTypeCombo.Name = "paymentTypeCombo";
            this.paymentTypeCombo.Size = new System.Drawing.Size(193, 21);
            this.paymentTypeCombo.TabIndex = 30;
            // 
            // billingDatePicker
            // 
            this.billingDatePicker.Location = new System.Drawing.Point(48, 360);
            this.billingDatePicker.Name = "billingDatePicker";
            this.billingDatePicker.Size = new System.Drawing.Size(200, 20);
            this.billingDatePicker.TabIndex = 29;
            // 
            // billingDateLab
            // 
            this.billingDateLab.AutoSize = true;
            this.billingDateLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingDateLab.Location = new System.Drawing.Point(44, 335);
            this.billingDateLab.Name = "billingDateLab";
            this.billingDateLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.billingDateLab.Size = new System.Drawing.Size(85, 22);
            this.billingDateLab.TabIndex = 28;
            this.billingDateLab.Text = "Due Date";
            // 
            // paymentAmtInp
            // 
            this.paymentAmtInp.Location = new System.Drawing.Point(48, 240);
            this.paymentAmtInp.Name = "paymentAmtInp";
            this.paymentAmtInp.Size = new System.Drawing.Size(193, 20);
            this.paymentAmtInp.TabIndex = 27;
            // 
            // paymentAmtLab
            // 
            this.paymentAmtLab.AutoSize = true;
            this.paymentAmtLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentAmtLab.Location = new System.Drawing.Point(44, 215);
            this.paymentAmtLab.Name = "paymentAmtLab";
            this.paymentAmtLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paymentAmtLab.Size = new System.Drawing.Size(76, 22);
            this.paymentAmtLab.TabIndex = 26;
            this.paymentAmtLab.Text = "Amount";
            // 
            // paymentNameInp
            // 
            this.paymentNameInp.Location = new System.Drawing.Point(48, 157);
            this.paymentNameInp.Name = "paymentNameInp";
            this.paymentNameInp.Size = new System.Drawing.Size(193, 20);
            this.paymentNameInp.TabIndex = 25;
            // 
            // paymentNameLab
            // 
            this.paymentNameLab.AutoSize = true;
            this.paymentNameLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentNameLab.Location = new System.Drawing.Point(44, 132);
            this.paymentNameLab.Name = "paymentNameLab";
            this.paymentNameLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paymentNameLab.Size = new System.Drawing.Size(134, 22);
            this.paymentNameLab.TabIndex = 24;
            this.paymentNameLab.Text = "Payment Name";
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(48, 77);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(193, 21);
            this.categoryCombo.TabIndex = 23;
            // 
            // CategoryLab
            // 
            this.CategoryLab.AutoSize = true;
            this.CategoryLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLab.Location = new System.Drawing.Point(44, 52);
            this.CategoryLab.Name = "CategoryLab";
            this.CategoryLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryLab.Size = new System.Drawing.Size(84, 22);
            this.CategoryLab.TabIndex = 22;
            this.CategoryLab.Text = "Category";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(81)))));
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(30, 598);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(498, 47);
            this.confirmButton.TabIndex = 34;
            this.confirmButton.Text = "Confirm Changes";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.confirmButton_MouseClick);
            // 
            // EditPaymentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(559, 749);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.CompleteBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goalTypeLab);
            this.Controls.Add(this.paymentTypeCombo);
            this.Controls.Add(this.billingDatePicker);
            this.Controls.Add(this.billingDateLab);
            this.Controls.Add(this.paymentAmtInp);
            this.Controls.Add(this.paymentAmtLab);
            this.Controls.Add(this.paymentNameInp);
            this.Controls.Add(this.paymentNameLab);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.CategoryLab);
            this.Name = "EditPaymentsPage";
            this.Text = "EditPaymentsPage";
            this.Load += new System.EventHandler(this.EditPaymentsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CompleteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label goalTypeLab;
        private System.Windows.Forms.ComboBox paymentTypeCombo;
        private System.Windows.Forms.DateTimePicker billingDatePicker;
        private System.Windows.Forms.Label billingDateLab;
        private System.Windows.Forms.TextBox paymentAmtInp;
        private System.Windows.Forms.Label paymentAmtLab;
        private System.Windows.Forms.TextBox paymentNameInp;
        private System.Windows.Forms.Label paymentNameLab;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label CategoryLab;
        private System.Windows.Forms.Button confirmButton;
    }
}