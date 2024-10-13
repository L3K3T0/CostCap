﻿using System;
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
    public partial class BudgetingNotification : Form
    {
        string Message { get; set; }
        Timer timer = new Timer();
        public BudgetingNotification(string message)
        {
            InitializeComponent();
            timer.Interval = 4000;
            this.Message = message;
            messageLab.Text = Message; 
        }

        private void BudgetingNotification_Load(object sender, EventArgs e)
        {
            timer.Start();
            timer.Tick += OnTimerTick;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            timer.Stop();
            Dispose();
        }
    }
}
