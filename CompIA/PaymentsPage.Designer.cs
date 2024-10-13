namespace CompIA
{
    partial class PaymentsPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.un_label = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.prioProgressLab3 = new System.Windows.Forms.Label();
            this.priorityLab3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prioProgressLab2 = new System.Windows.Forms.Label();
            this.priorityLab2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priorityLab = new System.Windows.Forms.Label();
            this.prioProgressLab = new System.Windows.Forms.Label();
            this.newCatButton = new System.Windows.Forms.Button();
            this.newPaymentBtn = new System.Windows.Forms.Button();
            this.newGoalButton = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.finChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lifeTimeLab = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLab = new System.Windows.Forms.Label();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costCapDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.costCapDBDataSet = new CompIA.CostCapDBDataSet();
            this.costCapDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new CompIA.CostCapDBDataSetTableAdapters.PaymentsTableAdapter();
            this.CatLabelText = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finChart)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCapDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCapDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCapDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.un_label);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 76);
            this.panel1.TabIndex = 2;
            // 
            // un_label
            // 
            this.un_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.un_label.Location = new System.Drawing.Point(1009, 29);
            this.un_label.Name = "un_label";
            this.un_label.Size = new System.Drawing.Size(159, 42);
            this.un_label.TabIndex = 3;
            this.un_label.Text = "*username*";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Title.Location = new System.Drawing.Point(116, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(128, 33);
            this.Title.TabIndex = 2;
            this.Title.Text = "CostCap";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CompIA.Properties.Resources.pngfind_com_placeholder_png_6104451;
            this.pictureBox2.Location = new System.Drawing.Point(1174, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CompIA.Properties.Resources.home_FILL0_wght400_GRAD0_opsz241;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel4.Controls.Add(this.prioProgressLab3);
            this.panel4.Controls.Add(this.priorityLab3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(108, 251);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 43);
            this.panel4.TabIndex = 7;
            // 
            // prioProgressLab3
            // 
            this.prioProgressLab3.AutoSize = true;
            this.prioProgressLab3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioProgressLab3.ForeColor = System.Drawing.Color.White;
            this.prioProgressLab3.Location = new System.Drawing.Point(82, 24);
            this.prioProgressLab3.Name = "prioProgressLab3";
            this.prioProgressLab3.Size = new System.Drawing.Size(0, 26);
            this.prioProgressLab3.TabIndex = 3;
            this.prioProgressLab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priorityLab3
            // 
            this.priorityLab3.AutoSize = true;
            this.priorityLab3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.priorityLab3.ForeColor = System.Drawing.Color.White;
            this.priorityLab3.Location = new System.Drawing.Point(10, 10);
            this.priorityLab3.Name = "priorityLab3";
            this.priorityLab3.Size = new System.Drawing.Size(156, 19);
            this.priorityLab3.TabIndex = 0;
            this.priorityLab3.Text = "Not enough Payments";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.prioProgressLab2);
            this.panel3.Controls.Add(this.priorityLab2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(108, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 52);
            this.panel3.TabIndex = 6;
            // 
            // prioProgressLab2
            // 
            this.prioProgressLab2.AutoSize = true;
            this.prioProgressLab2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioProgressLab2.ForeColor = System.Drawing.Color.White;
            this.prioProgressLab2.Location = new System.Drawing.Point(100, 31);
            this.prioProgressLab2.Name = "prioProgressLab2";
            this.prioProgressLab2.Size = new System.Drawing.Size(0, 26);
            this.prioProgressLab2.TabIndex = 2;
            this.prioProgressLab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priorityLab2
            // 
            this.priorityLab2.AutoSize = true;
            this.priorityLab2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLab2.ForeColor = System.Drawing.Color.White;
            this.priorityLab2.Location = new System.Drawing.Point(10, 12);
            this.priorityLab2.Name = "priorityLab2";
            this.priorityLab2.Size = new System.Drawing.Size(180, 19);
            this.priorityLab2.TabIndex = 0;
            this.priorityLab2.Text = "Not enough payments";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.priorityLab);
            this.panel2.Controls.Add(this.prioProgressLab);
            this.panel2.Location = new System.Drawing.Point(108, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 66);
            this.panel2.TabIndex = 5;
            // 
            // priorityLab
            // 
            this.priorityLab.AutoSize = true;
            this.priorityLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLab.ForeColor = System.Drawing.Color.White;
            this.priorityLab.Location = new System.Drawing.Point(14, 14);
            this.priorityLab.Name = "priorityLab";
            this.priorityLab.Size = new System.Drawing.Size(154, 28);
            this.priorityLab.TabIndex = 0;
            this.priorityLab.Text = "No Payments";
            // 
            // prioProgressLab
            // 
            this.prioProgressLab.AutoSize = true;
            this.prioProgressLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioProgressLab.ForeColor = System.Drawing.Color.White;
            this.prioProgressLab.Location = new System.Drawing.Point(100, 42);
            this.prioProgressLab.Name = "prioProgressLab";
            this.prioProgressLab.Size = new System.Drawing.Size(0, 26);
            this.prioProgressLab.TabIndex = 1;
            this.prioProgressLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newCatButton
            // 
            this.newCatButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCatButton.Location = new System.Drawing.Point(311, 426);
            this.newCatButton.Name = "newCatButton";
            this.newCatButton.Size = new System.Drawing.Size(203, 23);
            this.newCatButton.TabIndex = 13;
            this.newCatButton.Text = "New Category";
            this.newCatButton.UseVisualStyleBackColor = true;
            this.newCatButton.Click += new System.EventHandler(this.newCatButton_Click);
            // 
            // newPaymentBtn
            // 
            this.newPaymentBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPaymentBtn.Location = new System.Drawing.Point(108, 426);
            this.newPaymentBtn.Name = "newPaymentBtn";
            this.newPaymentBtn.Size = new System.Drawing.Size(197, 23);
            this.newPaymentBtn.TabIndex = 12;
            this.newPaymentBtn.Text = "New Payment";
            this.newPaymentBtn.UseVisualStyleBackColor = true;
            this.newPaymentBtn.Click += new System.EventHandler(this.newGoalBtn_Click);
            // 
            // newGoalButton
            // 
            this.newGoalButton.AutoScroll = true;
            this.newGoalButton.Location = new System.Drawing.Point(108, 452);
            this.newGoalButton.Margin = new System.Windows.Forms.Padding(0);
            this.newGoalButton.Name = "newGoalButton";
            this.newGoalButton.Size = new System.Drawing.Size(1108, 257);
            this.newGoalButton.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.finChart);
            this.panel6.Controls.Add(this.lifeTimeLab);
            this.panel6.Location = new System.Drawing.Point(399, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(309, 309);
            this.panel6.TabIndex = 14;
            // 
            // finChart
            // 
            chartArea1.Name = "ChartArea1";
            this.finChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.finChart.Legends.Add(legend1);
            this.finChart.Location = new System.Drawing.Point(7, 39);
            this.finChart.Name = "finChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "DoughnutRadius=20, CollectedThresholdUsePercent=False, CollectedColor=White";
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.finChart.Series.Add(series1);
            this.finChart.Size = new System.Drawing.Size(291, 267);
            this.finChart.TabIndex = 2;
            this.finChart.Text = "chart1";
            // 
            // lifeTimeLab
            // 
            this.lifeTimeLab.AutoSize = true;
            this.lifeTimeLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeTimeLab.Location = new System.Drawing.Point(3, 14);
            this.lifeTimeLab.Name = "lifeTimeLab";
            this.lifeTimeLab.Size = new System.Drawing.Size(219, 22);
            this.lifeTimeLab.TabIndex = 1;
            this.lifeTimeLab.Text = "Lifetime Goal Completion";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.tableLab);
            this.panel5.Location = new System.Drawing.Point(714, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 309);
            this.panel5.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.PaymentName,
            this.amountPaid});
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // PaymentName
            // 
            this.PaymentName.HeaderText = "Payment Name";
            this.PaymentName.Name = "PaymentName";
            this.PaymentName.ReadOnly = true;
            this.PaymentName.Width = 170;
            // 
            // amountPaid
            // 
            this.amountPaid.HeaderText = "Amount Paid";
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.ReadOnly = true;
            this.amountPaid.Width = 140;
            // 
            // tableLab
            // 
            this.tableLab.AutoSize = true;
            this.tableLab.Location = new System.Drawing.Point(5, 11);
            this.tableLab.Name = "tableLab";
            this.tableLab.Size = new System.Drawing.Size(112, 13);
            this.tableLab.TabIndex = 1;
            this.tableLab.Text = "Showing subscriptions";
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.costCapDBDataSetBindingSource1;
            // 
            // costCapDBDataSetBindingSource1
            // 
            this.costCapDBDataSetBindingSource1.DataSource = this.costCapDBDataSet;
            this.costCapDBDataSetBindingSource1.Position = 0;
            // 
            // costCapDBDataSet
            // 
            this.costCapDBDataSet.DataSetName = "CostCapDBDataSet";
            this.costCapDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costCapDBDataSetBindingSource
            // 
            this.costCapDBDataSetBindingSource.DataSource = this.costCapDBDataSet;
            this.costCapDBDataSetBindingSource.Position = 0;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // CatLabelText
            // 
            this.CatLabelText.AutoSize = true;
            this.CatLabelText.Location = new System.Drawing.Point(520, 436);
            this.CatLabelText.Name = "CatLabelText";
            this.CatLabelText.Size = new System.Drawing.Size(274, 13);
            this.CatLabelText.TabIndex = 16;
            this.CatLabelText.Text = "**Make Sure to add a new Category before a Payment!**";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(715, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 23);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Switch to One-Time payments";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PaymentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 720);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CatLabelText);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.newCatButton);
            this.Controls.Add(this.newPaymentBtn);
            this.Controls.Add(this.newGoalButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentsPage";
            this.Text = "PaymentsPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentsPage_FormClosed);
            this.Load += new System.EventHandler(this.PaymentsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finChart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCapDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCapDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCapDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label un_label;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label prioProgressLab3;
        private System.Windows.Forms.Label priorityLab3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label prioProgressLab2;
        private System.Windows.Forms.Label priorityLab2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label priorityLab;
        private System.Windows.Forms.Label prioProgressLab;
        private System.Windows.Forms.Button newCatButton;
        private System.Windows.Forms.Button newPaymentBtn;
        private System.Windows.Forms.FlowLayoutPanel newGoalButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart finChart;
        private System.Windows.Forms.Label lifeTimeLab;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingSource costCapDBDataSetBindingSource1;
        private CostCapDBDataSet costCapDBDataSet;
        private System.Windows.Forms.BindingSource costCapDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private CostCapDBDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.Label CatLabelText;
        private System.Windows.Forms.Label tableLab;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaid;
    }
}