using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdbojkaskiSavez
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT korisnikid, uloga FROM korisnici WHERE email=@email AND sifra=@sifra",
                    veza
                );

                cmd.Parameters.AddWithValue("@email", textBoxemail.Text.Trim());
                cmd.Parameters.AddWithValue("@sifra", textBoxlozinka.Text.Trim());

                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("Pogrešan email ili šifra.");
                    veza.Close();
                    return;
                }

                int korisnikid = Convert.ToInt32(dr["korisnikid"]);
                int uloga = Convert.ToInt32(dr["uloga"]);

                veza.Close();

                Form f = null;

                switch (uloga)
                {
                    case 0:
                        f = new Admin1();
                        break;

                    case 1:
                        f = new IgracForma(korisnikid);
                        break;

                    case 2:
                        f = new TrenerForma(korisnikid);
                        break;

                    case 3:
                        f = new Sudija(korisnikid); 
                        break;

                    default:
                        f = new GledalacForma();
                        break;
                }

                f.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
        private void gledalac_Click(object sender, EventArgs e)
        {
            GledalacForma f = new GledalacForma();
            f.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}