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
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }

        private void loginhere_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Bhujxu");
        }

        

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            string verify="user";
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            string query = "insert into login (Username,Password,email,verify) Values ('"+usernametext.Text+"','"+password.Text+ "','"+emailtextbox.Text+ "','"+verify+"')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MyGlobal.logintimer = 1;
        }
    }
}
