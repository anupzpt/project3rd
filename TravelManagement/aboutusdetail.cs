﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class aboutusdetail : UserControl
    {
        public aboutusdetail()
        {
            InitializeComponent();
        }

        private void aboutusdetail_Load(object sender, EventArgs e)
        {
            guna2ShadowPanel1.Size = new Size(800,400);
            imagepanel.Location = new Point(250, 30);
        }
    }
}
