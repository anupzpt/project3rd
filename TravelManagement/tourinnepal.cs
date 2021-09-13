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
    public partial class tourinnepal : UserControl
    {
        public tourinnepal()
        {
            InitializeComponent();
        }
        int SN = 1;

        private void tourinnepal_Load(object sender, EventArgs e)
        {
            tournepal.Location = new Point(635, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400, 100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
           // SqlConnection con = new SqlConnection(MyGlobal.constring);
           // string query = "Select *from changepanel where SN ='" + SN + "'";
         //   SqlDataAdapter sda = new SqlDataAdapter(query, con);
          //  DataTable dt = new DataTable();
            //sda.Fill(dt);
           // string bestpanel = dt.Rows[0]["Picture"].ToString();
          //  string label = dt.Rows[0]["Pricelabel"].ToString();
          //  string destination = dt.Rows[0]["Location"].ToString();
          //  bestpanel1.BackgroundImage = Image.FromFile("bestpanel");

            


        }

        private void darjellingbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
