namespace CompIA
{
    partial class ListHeaderPay
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.billingDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paymentName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.purchaseType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paymentAmount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.billingDate);
            this.panel2.Location = new System.Drawing.Point(469, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 50);
            this.panel2.TabIndex = 4;
            // 
            // billingDate
            // 
            this.billingDate.AutoSize = true;
            this.billingDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.billingDate.ForeColor = System.Drawing.Color.Black;
            this.billingDate.Location = new System.Drawing.Point(3, 17);
            this.billingDate.Name = "billingDate";
            this.billingDate.Size = new System.Drawing.Size(110, 17);
            this.billingDate.TabIndex = 0;
            this.billingDate.Text = "Last Billing Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paymentName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 50);
            this.panel1.TabIndex = 3;
            // 
            // paymentName
            // 
            this.paymentName.AutoSize = true;
            this.paymentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentName.ForeColor = System.Drawing.Color.Black;
            this.paymentName.Location = new System.Drawing.Point(21, 17);
            this.paymentName.Name = "paymentName";
            this.paymentName.Size = new System.Drawing.Size(134, 22);
            this.paymentName.TabIndex = 1;
            this.paymentName.Text = "Payment Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.purchaseType);
            this.panel4.Location = new System.Drawing.Point(236, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 50);
            this.panel4.TabIndex = 6;
            // 
            // purchaseType
            // 
            this.purchaseType.AutoSize = true;
            this.purchaseType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseType.ForeColor = System.Drawing.Color.Black;
            this.purchaseType.Location = new System.Drawing.Point(21, 17);
            this.purchaseType.Name = "purchaseType";
            this.purchaseType.Size = new System.Drawing.Size(148, 22);
            this.purchaseType.TabIndex = 1;
            this.purchaseType.Text = "Type of Purchase";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.paymentAmount);
            this.panel3.Location = new System.Drawing.Point(699, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 50);
            this.panel3.TabIndex = 7;
            // 
            // paymentAmount
            // 
            this.paymentAmount.AutoSize = true;
            this.paymentAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentAmount.ForeColor = System.Drawing.Color.Black;
            this.paymentAmount.Location = new System.Drawing.Point(21, 17);
            this.paymentAmount.Name = "paymentAmount";
            this.paymentAmount.Size = new System.Drawing.Size(152, 22);
            this.paymentAmount.TabIndex = 1;
            this.paymentAmount.Text = "Payment Amount";
            // 
            // ListHeaderPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListHeaderPay";
            this.Size = new System.Drawing.Size(1070, 50);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label billingDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label paymentName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label purchaseType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label paymentAmount;
    }
}
