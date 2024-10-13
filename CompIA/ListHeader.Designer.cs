
namespace CompIA
{
    partial class ListHeader
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
            this.dueDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progress = new System.Windows.Forms.Label();
            this.goalName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dueDate);
            this.panel2.Location = new System.Drawing.Point(456, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 50);
            this.panel2.TabIndex = 1;
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate.ForeColor = System.Drawing.Color.Black;
            this.dueDate.Location = new System.Drawing.Point(3, 17);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(85, 22);
            this.dueDate.TabIndex = 0;
            this.dueDate.Text = "Date Due";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progress);
            this.panel3.Location = new System.Drawing.Point(574, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 50);
            this.panel3.TabIndex = 2;
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.Color.Black;
            this.progress.Location = new System.Drawing.Point(21, 17);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(82, 22);
            this.progress.TabIndex = 1;
            this.progress.Text = "Progress";
            // 
            // goalName
            // 
            this.goalName.AutoSize = true;
            this.goalName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalName.ForeColor = System.Drawing.Color.Black;
            this.goalName.Location = new System.Drawing.Point(21, 17);
            this.goalName.Name = "goalName";
            this.goalName.Size = new System.Drawing.Size(100, 22);
            this.goalName.TabIndex = 1;
            this.goalName.Text = "Goal Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.goalName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 50);
            this.panel1.TabIndex = 0;
            // 
            // ListHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListHeader";
            this.Size = new System.Drawing.Size(1070, 50);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dueDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label goalName;
        private System.Windows.Forms.Panel panel1;
    }
}
