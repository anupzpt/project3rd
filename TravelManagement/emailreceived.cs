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
    public partial class emailreceived : UserControl
    {
        public emailreceived()
        {
            InitializeComponent();
        }

        private void emailreceived_Load(object sender, EventArgs e)
        {
            string datestore=null;
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            string query = "insert into booking (title,message,date,sender,reciver) Values ('" + subjecttextbox.Text + "','" + messagedisplaylabel.Text + "','" + datestore + "','" +sendertextbox.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("SAVE");
        }
    }
}
