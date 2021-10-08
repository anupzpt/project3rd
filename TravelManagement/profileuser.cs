using System;
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
    public partial class profileuser : UserControl
    {
        public profileuser()
        {
            InitializeComponent();
        }

        private void Booked_Click(object sender, EventArgs e)
        {
            bookeduser.Visible = true;
            updateuser.Visible = false;
            deleteuser.Visible = false;

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            updateuser.Visible = true;
            bookeduser.Visible = false;
            deleteuser.Visible = false;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            deleteuser.Visible = true;
            bookeduser.Visible = false;
            updateuser.Visible = false;
        }

        private void profileuser_Load(object sender, EventArgs e)
        {
            panelforbutton.Location = new Point(240, 0);
            bookeduser.Location = new Point(240, 50);
            bookeduser.Size = new Size(900, 400);
            updateuser.Location = new Point(240, 50);
            updateuser.Size = new Size(900, 400);
            deleteuser.Location = new Point(240, 50);
            deleteuser.Size = new Size(900, 400);
        }
    }
}
