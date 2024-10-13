namespace CompIA
{
    partial class CategoryBox
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
            this.CategoryInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmChangeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryInp
            // 
            this.CategoryInp.Location = new System.Drawing.Point(58, 70);
            this.CategoryInp.Name = "CategoryInp";
            this.CategoryInp.Size = new System.Drawing.Size(249, 20);
            this.CategoryInp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the name of the Category";
            // 
            // confirmChangeBtn
            // 
            this.confirmChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(81)))));
            this.confirmChangeBtn.FlatAppearance.BorderSize = 0;
            this.confirmChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmChangeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmChangeBtn.Location = new System.Drawing.Point(58, 176);
            this.confirmChangeBtn.Name = "confirmChangeBtn";
            this.confirmChangeBtn.Size = new System.Drawing.Size(352, 23);
            this.confirmChangeBtn.TabIndex = 2;
            this.confirmChangeBtn.Text = "Confirm Name";
            this.confirmChangeBtn.UseVisualStyleBackColor = false;
            this.confirmChangeBtn.Click += new System.EventHandler(this.confirmChangeBtn_Click);
            // 
            // CategoryBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.confirmChangeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryInp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryBox";
            this.Text = "CategoryBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryInp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmChangeBtn;
    }
}