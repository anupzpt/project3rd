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

        private void gunaLinkLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Good Job");
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
                string admin = dt.Rows[0]["Admin"].ToString();
                string user = dt.Rows[0]["Users"].ToString();

                int check = Convert.ToInt32(admin);
                if (check == 1)
                {
                    MessageBox.Show("Welcome Admin");
                }
                else
                {
                    //   MessageBox.Show("Invalid Logged In !!");

                }
                int check2 = Convert.ToInt32(user);
                if (check2 == 1)
                {
                    MessageBox.Show("Welcome User");
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
    }
}
