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
    public partial class trekkingusercontrol : UserControl
    {
        public trekkingusercontrol()
        {
            InitializeComponent();
        }

        private void trekkingusercontrol_Load(object sender, EventArgs e)
        {
            trekking.Size = new Size(840, 489);
            trekkinginnepal.Location = new Point(0, 492);
            trekkinginnepal.Size = new Size(900, 400);
            lastpanel.Size = new Size(840, 203);
            lastpanel.Location = new Point(0, 1000);
        }
    }
}
