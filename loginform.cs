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

namespace proftaakp2
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            Form sensoren = new Form2(); 
            using (SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Hicham\Documents\Visual Studio 2015\Projects\proftaakp2\proftaakp2\logins.mdf; Integrated Security = True"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM [Table] 
                                        WHERE Username=@uname and 
                                        Password=@pass", Connection);
                    cmd.Parameters.AddWithValue("@uname", tbgebruikersnaam.Text);
                    cmd.Parameters.AddWithValue("@pass", tbwachtwoord.Text);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("U bent met succes ingelogd");
                        sensoren.Show();
                    }
                    else
                        MessageBox.Show("Fout: Incorrecte login");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
            }
        }
    }
}
