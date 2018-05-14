﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainView
{
    public partial class HomePanel : Form
    {
        public MainFrame main;
        public HomePanel( MainFrame frame)
        {
            main = frame;
            InitializeComponent();
        }

       

        private void BtDailyAnalysis_Click(object sender, EventArgs e)
        {
            main.ShowFormVisualization();
        }
    }
}
