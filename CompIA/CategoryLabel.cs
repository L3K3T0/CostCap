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
    public partial class CategoryLabel : UserControl
    {
        public CategoryLabel()
        {
            InitializeComponent();
        }
        private string _categoryLab;

        [Category("Custom Props")]
        public string CategoryLabelText
        {
            get { return _categoryLab; }
            set { _categoryLab = value; CategoryLab.Text = value;  }
        }
        private Color bkgColor;

        [Category("Custom Props")]
        public Color BkgColor
        {
            get { return bkgColor; }
            set { bkgColor = value; this.BackColor = value; }
        }

    }
}
