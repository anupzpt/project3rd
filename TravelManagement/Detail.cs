using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class Detail : UserControl
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void detailpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Detail_Load(object sender, EventArgs e)
        {
            //  detailshadowpanel.Location = new Point(0, 492);
            //   detailshadowpanel.Size = new Size(900, 400);
            panel1.Location = new Point(45,20);
            detaillabel.Location = new Point(62, 89);
            detaillabel.Size = new Size(900, 280);
            bookpanel.Location = new Point(270, 45);
            bookpanel.Size = new Size(400, 360);
            Refreshtimer.Start();
        // // //  Crossbutton.Location = new Point(780,10);
        }

        private void detailshadowpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bookbutton_Click(object sender, EventArgs e)
        {
            string name;
            string number;
            string emailaddress;
            string datepicker;
            string quantity;
            name = nametextbox.Text;
            number = Phone.Text;
            emailaddress = Email.Text;
            datepicker = date.Text;
            quantity = Quantity.Text;
            MessageBox.Show(name);
            MessageBox.Show(number);
            MessageBox.Show(emailaddress);
            MessageBox.Show(datepicker);
            MessageBox.Show(quantity);

        }

        private void nametextbox_MouseDown(object sender, MouseEventArgs e)
        {
            nametextbox.Text = null;
        }

        private void Phone_MouseDown(object sender, MouseEventArgs e)
        {
            Phone.Text = null;
        }

        private void Email_MouseDown(object sender, MouseEventArgs e)
        {
            Email.Text = null;
        }

        private void Quantity_MouseDown(object sender, MouseEventArgs e)
        {
            Quantity.Text = null;
        }

        

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validlabel.Visible = false;
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if ((char.IsLetter(e.KeyChar) ))
            {
                e.Handled = true;
                validlabel.Visible = true;
            }
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            quantityvalidity.Visible = false;
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            if ((char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                quantityvalidity.Visible = true;
            }
        }

        private void includebutton_Click(object sender, EventArgs e)
        {
            detaillabel.Visible = false;
            includepanel.Visible = true;
            includepanel.BringToFront();
            excludepanel.Visible = false;
        }

        private void detailbutton_Click(object sender, EventArgs e)
        { 
           
            detaillabel.Visible = true;
            includepanel.Visible = false;
            excludepanel.Visible = false;
          
        }

        private void excludebutton_Click(object sender, EventArgs e)
        {
            excludepanel.Visible = true;
            excludepanel.BringToFront();
            includepanel.Visible = false;
            detaillabel.Visible =false;

        }

        private void detaillabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);

            try
            {
                con.Open();
                string query = "Select *from trekchangepanel where SN='" + MyGlobal.SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string description = dt.Rows[0]["description"].ToString();
                string duration = dt.Rows[0]["duration"].ToString();
                string tripprice = dt.Rows[0]["trekpricelabel"].ToString();
                string accomodation = dt.Rows[0]["accomodation"].ToString();
                string transport = dt.Rows[0]["transport"].ToString();
                detailtext.Text = description;
                durationlabel.Text = duration;
                trippricelabel.Text = tripprice;
                accomodationlabel.Text = accomodation;
                transportlabel.Text = transport;
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
