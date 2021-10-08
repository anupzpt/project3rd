using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelManagement
{
    public partial class loggedin : UserControl
    {
        public loggedin()
        {
            InitializeComponent();
        }
        private void loggedin_Load(object sender, EventArgs e)
        {
            Refreshtimer.Start();
        }
        private void gunaLinkLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            register.Visible = true;
            register.BringToFront();
            MyGlobal.logintimer = 2;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);

            try
            {
                con.Open();
                string query = "select *from login where Username='" + usertextbox.Text + "'";
                SqlDataAdapter sta = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sta.Fill(dt);
                //string admin = dt.Rows[0]["Admin"].ToString();
                //string user = dt.Rows[0]["Users"].ToString();
                MyGlobal.username = dt.Rows[0]["Username"].ToString();
                string verify = dt.Rows[0]["verify"].ToString();
                MyGlobal.loginsucess = 1;

                if (string.Equals(verify,"admin"))
                {
                    MyGlobal.admin = 1;
                    MyGlobal.user = 0;


                }
                else
                {
                    //   MessageBox.Show("Invalid Logged In !!");

                }
                
                if (string.Equals(verify, "user"))
                {
                    MyGlobal.user = 1;
                    MyGlobal.admin = 0;

                }
                else
                {
                    // MessageBox.Show("Invalid Logged In !!");
                }
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }

        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            if(MyGlobal.logintimer==1)
            {
                register.Visible = false;
                register.SendToBack();
            }
        }

        private void donthaveaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
