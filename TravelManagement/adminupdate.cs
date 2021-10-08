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
    public partial class adminupdate : UserControl
    {
        public adminupdate()
        {
            InitializeComponent();
        }
        string location;

        private void updatebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);

            con.Open();
            string query= "Update changepanel set Picture='" + imagetextbox.Text + "',Pricelabel='" + trippricetextbox.Text + "',Location='" + destinationtextbox.Text + "',Descripition='" + descriptiontextbox.Text + "',Duration='" + Durationtextbox.Text + "',Transport='" + transporttextbox.Text + "',tripprice='" + trippricetextbox.Text + "',Accomodation='" + accomodationtextbox.Text + "' Where CONVERT (VARCHAR , Location)='"+ location + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.ExecuteNonQuery();


        }

        private void adminupdate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            if(MyGlobal.admininfo==1)
            {

                try
                {
                    con.Open();

                    string image = "Select *from changepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; ;)
                    {
                        string destionation = dt.Rows[i]["Location"].ToString();
                        selectComboBox.Items.Add(destionation);

                        i++;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }
            if (MyGlobal.admininfo == 2)
            {
                try
                {
                    con.Open();

                    MessageBox.Show("audaixa ");
                    string image = "Select *from trekchangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; ;)
                    {
                        string destionation = dt.Rows[i]["treklocation"].ToString();
                        selectComboBox.Items.Add(destionation);

                        i++;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }
            if (MyGlobal.admininfo == 3)
            {
                try
                {
                    con.Open();

                    string image = "Select *from specialchangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; ;)
                    {
                        string destionation = dt.Rows[i]["speciallocation"].ToString();
                        selectComboBox.Items.Add(destionation);
                        i++;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }
            if (MyGlobal.admininfo == 4)
            {
                try
                {
                    string image = "Select *from hompagechangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; ;)
                    {
                        string destionation = dt.Rows[i]["hompagelocation"].ToString();
                        selectComboBox.Items.Add(destionation);
                        i++;
                    }
                } 
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = selectComboBox.Text;
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
             string query = "Select *From changepanel Where CONVERT(VARCHAR,Location)='" + selectComboBox.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt); 
             descriptiontextbox.Text = dt.Rows[0]["Descripition"].ToString();
                Durationtextbox.Text = dt.Rows[0]["Duration"].ToString();
                transporttextbox.Text = dt.Rows[0]["Transport"].ToString();

                accomodationtextbox.Text = dt.Rows[0]["Accomodation"].ToString();
                destinationtextbox.Text = dt.Rows[0]["Location"].ToString();
                trippricetextbox.Text = dt.Rows[0]["Pricelabel"].ToString();
            imagetextbox.Text = dt.Rows[0]["Picture"].ToString();
            imagepicturebox.Image = Image.FromFile(imagetextbox.Text);



          
        }
    }
}
