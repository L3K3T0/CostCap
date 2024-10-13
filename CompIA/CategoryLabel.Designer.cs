
namespace CompIA
{
    partial class CategoryLabel
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
            this.CategoryLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryLab
            // 
            this.CategoryLab.AutoSize = true;
            this.CategoryLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLab.Location = new System.Drawing.Point(3, 0);
            this.CategoryLab.Name = "CategoryLab";
            this.CategoryLab.Size = new System.Drawing.Size(222, 46);
            this.CategoryLab.TabIndex = 0;
            this.CategoryLab.Text = "Category 1 ";
            // 
            // CategoryLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoryLab);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CategoryLabel";
            this.Size = new System.Drawing.Size(1070, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLab;
    }
}
