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
    public partial class adminadd : UserControl
    {
        public adminadd()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);

            if(MyGlobal.admininfo==1)
            {
                try
                {
                    con.Open();
                    string query = "insert into changepanel (Picture,Pricelabel,Location,Descripition,Duration,Transport,Tripprice,Accomodation) Values ('" + imagetextbox.Text + "','" + trippricetextbox.Text + "','" + destinationtextbox.Text + "','" + descriptiontextbox.Text + "','" + Durationtextbox.Text + "','" + transporttextbox.Text + "','" + trippricetextbox.Text + "','" + accomodationtextbox.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SAVE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SAVED FAIL");
                }
                finally
                {
                    con.Close();
                }
            }
            if(MyGlobal.admininfo==2)
            {
                try
                {
                    con.Open();
                    string query = "insert into trekchangepanel (trekpicture,trekpricelabel,treklocation,description,duration,transport,tripprice,accomodation) Values ('" + imagetextbox.Text + "','" + trippricetextbox.Text + "','" + destinationtextbox.Text + "','" + descriptiontextbox.Text + "','" + Durationtextbox.Text + "','" + transporttextbox.Text + "','" + trippricetextbox.Text + "','" + accomodationtextbox.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SAVE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SAVED FAIL");
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
                    string query = "insert into specialchangepanel (specialpicture,specialpricelabel,speciallocation,descripition,duration,transport,tripprice,accomodation) Values ('" + imagetextbox.Text + "','" + trippricetextbox.Text + "','" + destinationtextbox.Text + "','" + descriptiontextbox.Text + "','" + Durationtextbox.Text + "','" + transporttextbox.Text + "','" + trippricetextbox.Text + "','" + accomodationtextbox.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SAVE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SAVED FAIL");
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
                    con.Open();
                    string query = "insert into hompagechangepanel (hompagepicture,hompagepricelabel,hompagelocation,descripition,duration,transport,tripprice,accomodation) Values ('" + imagetextbox.Text + "','" + trippricetextbox.Text + "','" + destinationtextbox.Text + "','" + descriptiontextbox.Text + "','" + Durationtextbox.Text + "','" + transporttextbox.Text + "','" + trippricetextbox.Text + "','" + accomodationtextbox.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("SAVE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SAVED FAIL");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void filebutton_Click(object sender, EventArgs e)
        {
            string imagelocation;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagelocation = dialog.FileName;
                imagetextbox.Text = imagelocation;
                imagepicturebox.Image = Image.FromFile(imagelocation);
            }
        }
    }
}
