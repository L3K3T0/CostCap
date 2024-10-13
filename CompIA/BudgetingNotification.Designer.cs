namespace CompIA
{
    partial class BudgetingNotification
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
            this.messageLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageLab
            // 
            this.messageLab.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLab.Location = new System.Drawing.Point(3, 9);
            this.messageLab.Name = "messageLab";
            this.messageLab.Size = new System.Drawing.Size(394, 43);
            this.messageLab.TabIndex = 0;
            this.messageLab.Text = "Message";
            // 
            // BudgetingNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(401, 61);
            this.ControlBox = false;
            this.Controls.Add(this.messageLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BudgetingNotification";
            this.Load += new System.EventHandler(this.BudgetingNotification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messageLab;
    }
}