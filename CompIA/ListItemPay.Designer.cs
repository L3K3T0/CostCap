namespace CompIA
{
    partial class ListItemPay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paymentName = new System.Windows.Forms.Label();
            this.billingDate = new System.Windows.Forms.Label();
            this.paymentAmount = new System.Windows.Forms.Label();
            this.Edit_lab = new System.Windows.Forms.Label();
            this.purchaseType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CompIA.Properties.Resources.Close_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(1034, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // paymentName
            // 
            this.paymentName.AutoSize = true;
            this.paymentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentName.ForeColor = System.Drawing.Color.Black;
            this.paymentName.Location = new System.Drawing.Point(12, 16);
            this.paymentName.Name = "paymentName";
            this.paymentName.Size = new System.Drawing.Size(134, 22);
            this.paymentName.TabIndex = 4;
            this.paymentName.Text = "Payment Name";
            this.paymentName.MouseEnter += new System.EventHandler(this.ListItemPay_MouseEnter);
            // 
            // billingDate
            // 
            this.billingDate.AutoSize = true;
            this.billingDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.billingDate.ForeColor = System.Drawing.Color.Black;
            this.billingDate.Location = new System.Drawing.Point(469, 18);
            this.billingDate.Name = "billingDate";
            this.billingDate.Size = new System.Drawing.Size(109, 19);
            this.billingDate.TabIndex = 3;
            this.billingDate.Text = "DD/MM/YYYY";
            this.billingDate.MouseEnter += new System.EventHandler(this.ListItemPay_MouseEnter);
            // 
            // paymentAmount
            // 
            this.paymentAmount.AutoSize = true;
            this.paymentAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentAmount.ForeColor = System.Drawing.Color.Black;
            this.paymentAmount.Location = new System.Drawing.Point(699, 16);
            this.paymentAmount.Name = "paymentAmount";
            this.paymentAmount.Size = new System.Drawing.Size(53, 22);
            this.paymentAmount.TabIndex = 5;
            this.paymentAmount.Text = "£XXX";
            this.paymentAmount.MouseEnter += new System.EventHandler(this.ListItemPay_MouseEnter);
            // 
            // Edit_lab
            // 
            this.Edit_lab.AutoSize = true;
            this.Edit_lab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_lab.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_lab.ForeColor = System.Drawing.SystemColors.Control;
            this.Edit_lab.Location = new System.Drawing.Point(889, 13);
            this.Edit_lab.Name = "Edit_lab";
            this.Edit_lab.Size = new System.Drawing.Size(79, 21);
            this.Edit_lab.TabIndex = 7;
            this.Edit_lab.Text = "Edit Item";
            this.Edit_lab.DoubleClick += new System.EventHandler(this.Edit_lab_DoubleClick);
            this.Edit_lab.MouseEnter += new System.EventHandler(this.ListItemPay_MouseEnter);
            // 
            // purchaseType
            // 
            this.purchaseType.AutoSize = true;
            this.purchaseType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseType.ForeColor = System.Drawing.Color.Black;
            this.purchaseType.Location = new System.Drawing.Point(236, 12);
            this.purchaseType.Name = "purchaseType";
            this.purchaseType.Size = new System.Drawing.Size(152, 22);
            this.purchaseType.TabIndex = 1;
            this.purchaseType.Text = "SubscriptionType";
            this.purchaseType.MouseEnter += new System.EventHandler(this.ListItemPay_MouseEnter);
            // 
            // ListItemPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.purchaseType);
            this.Controls.Add(this.Edit_lab);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paymentName);
            this.Controls.Add(this.billingDate);
            this.Controls.Add(this.paymentAmount);
            this.Name = "ListItemPay";
            this.Size = new System.Drawing.Size(1070, 50);
            this.MouseEnter += new System.EventHandler(this.ListItemPay_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItemPay_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label paymentName;
        private System.Windows.Forms.Label billingDate;
        private System.Windows.Forms.Label paymentAmount;
        private System.Windows.Forms.Label Edit_lab;
        private System.Windows.Forms.Label purchaseType;
    }
}
