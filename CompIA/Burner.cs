using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompIA
{
    public partial class Burner : Form
    {
        public Burner()
        {
            // loads the login form remember to replace with PageManager implementation.
            Login login = new Login();
            //login.Show();
            PageManager.GetBurner(this);
            PageManager.LoadMainForm(login);
            InitializeComponent();
 
        }

        private void Burner_Load(object sender, EventArgs e)
        {
            this.Size = new Size(0, 0);
            this.Opacity = 0.0f;
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.None;

        }
        // hiding from Alt+TAB dialog (hides it from when its being alt tabbed).
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80; // the 0x refers to it being hexadecimal and hex 80 = 128
                // |= is the bitwise or operator go to reference.
                return cp;
            }
        }
    }
}
