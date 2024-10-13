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
    public partial class ListHeader : UserControl
    {
        public ListHeader()
        {
            InitializeComponent();
        }
        private string _goalName;

        [Category("Custom Props")]
        public string GoalName
        {
            get { return _goalName; }
            set { _goalName = value; goalName.Text = value; }
        }
        private string _dueDate;
        [Category("Custom Props")]
        public string DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; dueDate.Text = value; }
        }

        private string _progress;
        [Category("Custom Props")]
        public string Progress
        {
            get { return _progress; }
            set { _progress = value; progress.Text = value; }
        }
        private Color bkgcolor;

        public Color BkgColor
        {
            get { return bkgcolor; }
            set { bkgcolor = value; this.BackColor = value; }
        }

    }
}
