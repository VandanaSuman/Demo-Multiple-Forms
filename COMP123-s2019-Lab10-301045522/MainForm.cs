﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_s2019_Lab10_301045522
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

         MainForm mainForm = new MainForm();

          mainForm.Show(); 
          StartForm.Hide(); 
private void MainFormButton_Click(object sender, EventArgs e)
        {
            EndForm.Show();
            MainForm.Hide();
        }
    }
}
