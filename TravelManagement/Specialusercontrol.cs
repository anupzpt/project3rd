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
    public partial class Specialusercontrol : UserControl
    {
        public Specialusercontrol()
        {
            InitializeComponent();
        }

        private void Specialusercontrol_Load(object sender, EventArgs e)
        {
            special.Size = new Size(840, 489);
            specialdetail.Location = new Point(0, 492);
            specialdetail.Size = new Size(900, 400);
            lastpanel.Location = new Point(0, 1000);
        }
    }
}
