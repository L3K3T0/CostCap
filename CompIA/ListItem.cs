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
    public partial class ListItem : UserControl
    {
        EventHandler GoalRemoved;
        public ListItem(GoalsPage goalsPage)
        {
            InitializeComponent();
            this.goalsPage = goalsPage;
            GoalRemoved += goalsPage.OnGoalsChangedEvent;
        }
        #region Properties
        private string _goalName;

        [Category("Custom Props")]// <---Allows these properties to be accessible in the visual design editor
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
        private int _goalid;

        public int GoalID
        {
            get { return _goalid; }
            set { _goalid = value; }
        }
        private int _userid;

        public int UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }
        public GoalsPage goalsPage;
        #endregion
        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse is hovering over it will just become silver
            // Just some visual feedback
            BackColor = Color.Silver;
            Edit_lab.ForeColor = SystemColors.MenuHighlight;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            Edit_lab.ForeColor = SystemColors.Control;
        }

        private void Edit_lab_DoubleClick(object sender, EventArgs e)
        {
            //PageManager.LoadMainForm(new EditGoalPage(ID));
            new EditGoalPage(UserID,GoalID).Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DataBaseManager.RemoveGoal(GoalID);
            GoalRemoved?.Invoke(this,EventArgs.Empty);
        }
    }
}
