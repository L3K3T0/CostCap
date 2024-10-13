
namespace CompIA
{
    // use properties.resources to keep image values similar to unity resources .load();
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorMsgLab = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.pw_label = new System.Windows.Forms.Label();
            this.pw_input = new System.Windows.Forms.TextBox();
            this.un_label = new System.Windows.Forms.Label();
            this.un_input = new System.Windows.Forms.TextBox();
            this.loginLab = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.errorMsgLab);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.pw_label);
            this.panel1.Controls.Add(this.pw_input);
            this.panel1.Controls.Add(this.un_label);
            this.panel1.Controls.Add(this.un_input);
            this.panel1.Controls.Add(this.loginLab);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 841);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // errorMsgLab
            // 
            this.errorMsgLab.AutoSize = true;
            this.errorMsgLab.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsgLab.Location = new System.Drawing.Point(97, 433);
            this.errorMsgLab.Name = "errorMsgLab";
            this.errorMsgLab.Size = new System.Drawing.Size(0, 32);
            this.errorMsgLab.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(81)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Forgot Password?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(81)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign Up!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(81)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(38, 468);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(498, 47);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pw_label.Location = new System.Drawing.Point(13, 239);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(79, 21);
            this.pw_label.TabIndex = 5;
            this.pw_label.Text = "Password";
            // 
            // pw_input
            // 
            this.pw_input.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.pw_input.Location = new System.Drawing.Point(17, 263);
            this.pw_input.Name = "pw_input";
            this.pw_input.Size = new System.Drawing.Size(233, 22);
            this.pw_input.TabIndex = 4;
            // 
            // un_label
            // 
            this.un_label.AutoSize = true;
            this.un_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.un_label.Location = new System.Drawing.Point(13, 178);
            this.un_label.Name = "un_label";
            this.un_label.Size = new System.Drawing.Size(83, 21);
            this.un_label.TabIndex = 3;
            this.un_label.Text = "Username";
            // 
            // un_input
            // 
            this.un_input.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.un_input.Location = new System.Drawing.Point(17, 202);
            this.un_input.Name = "un_input";
            this.un_input.Size = new System.Drawing.Size(233, 22);
            this.un_input.TabIndex = 2;
            // 
            // loginLab
            // 
            this.loginLab.AutoSize = true;
            this.loginLab.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.loginLab.Location = new System.Drawing.Point(10, 124);
            this.loginLab.Name = "loginLab";
            this.loginLab.Size = new System.Drawing.Size(85, 37);
            this.loginLab.TabIndex = 1;
            this.loginLab.Text = "Login";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(131, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(302, 77);
            this.Title.TabIndex = 0;
            this.Title.Text = "CostCap";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1134, 841);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 880);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox un_input;
        private System.Windows.Forms.Label loginLab;
        private System.Windows.Forms.Label un_label;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox pw_input;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorMsgLab;
    }
}

