﻿using System;
using System.Windows.Forms;

namespace Marathon_Skills.Forms
{
    public partial class SponsorConfirmForm : Form
    {
        public SponsorConfirmForm()
        {
            InitializeComponent();

            Program.LoadTime(label10);

            //label3.Text = runner;
            //label13.Text = fund;
            //label14.Text = amount;
        }

        private void Back(object sender, EventArgs e)
        {
            Program.MoveToForm<SponsorForm>(this);
        }
    }
}
