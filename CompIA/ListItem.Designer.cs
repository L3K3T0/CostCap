
namespace CompIA
{
    partial class ListItem
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
            this.progress = new System.Windows.Forms.Label();
            this.dueDate = new System.Windows.Forms.Label();
            this.goalName = new System.Windows.Forms.Label();
            this.Edit_lab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.Color.Black;
            this.progress.Location = new System.Drawing.Point(595, 17);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(104, 22);
            this.progress.TabIndex = 1;
            this.progress.Text = "£XXX/£XXX";
            this.progress.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.dueDate.ForeColor = System.Drawing.Color.Black;
            this.dueDate.Location = new System.Drawing.Point(458, 19);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(109, 19);
            this.dueDate.TabIndex = 0;
            this.dueDate.Text = "DD/MM/YYYY";
            this.dueDate.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
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
            this.goalName.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            // 
            // Edit_lab
            // 
            this.Edit_lab.AutoSize = true;
            this.Edit_lab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_lab.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_lab.ForeColor = System.Drawing.SystemColors.Control;
            this.Edit_lab.Location = new System.Drawing.Point(896, 14);
            this.Edit_lab.Name = "Edit_lab";
            this.Edit_lab.Size = new System.Drawing.Size(79, 21);
            this.Edit_lab.TabIndex = 0;
            this.Edit_lab.Text = "Edit Item";
            this.Edit_lab.DoubleClick += new System.EventHandler(this.Edit_lab_DoubleClick);
            this.Edit_lab.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CompIA.Properties.Resources.Close_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(1043, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Edit_lab);
            this.Controls.Add(this.goalName);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.progress);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(1070, 50);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label dueDate;
        private System.Windows.Forms.Label goalName;
        private System.Windows.Forms.Label Edit_lab;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
