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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private int selektovanId = -1;
        private void Admin_Load(object sender, EventArgs e)
        {
            comboBoxuloga.Items.Add("Igrac");
            comboBoxuloga.Items.Add("Sudija");
            comboBoxuloga.Items.Add("Trener");

            UcitajKorisnike();
        }
        private int VratiUlogu()
        {
            if (comboBoxuloga.SelectedItem == null)
                return 0;

            switch (comboBoxuloga.SelectedItem.ToString())
            {
                case "Igrac": return 1;
                case "Sudija": return 2;
                case "Trener": return 3;
                default: return 0;
            }
        }
        private void UcitajKorisnike()
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT korisnikid, email, sifra, ime, prezime, uloga FROM korisnici",
                    veza
                );

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                veza.Close();

                selektovanId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (comboBoxuloga.SelectedItem == null ||
                textBoxemail.Text == "" ||
                textBoxsifra.Text == "" ||
                textBoxime.Text == "" ||
                textBoxprezime.Text == "")
            {
                MessageBox.Show("Popuni sva polja!");
                return;
            }

            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                string query = @"INSERT INTO korisnici 
                                (email, sifra, ime, prezime, uloga)
                                VALUES (@email, @sifra, @ime, @prezime, @uloga)";

                SqlCommand cmd = new SqlCommand(query, veza);

                cmd.Parameters.AddWithValue("@email", textBoxemail.Text);
                cmd.Parameters.AddWithValue("@sifra", textBoxsifra.Text);
                cmd.Parameters.AddWithValue("@ime", textBoxime.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxprezime.Text);
                cmd.Parameters.AddWithValue("@uloga", VratiUlogu());

                cmd.ExecuteNonQuery();
                veza.Close();

                MessageBox.Show("Korisnik dodat!");

                UcitajKorisnike();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selektovanId = Convert.ToInt32(row.Cells["korisnikid"].Value);

            textBoxemail.Text = row.Cells["email"].Value.ToString();
            textBoxsifra.Text = row.Cells["sifra"].Value.ToString();
            textBoxime.Text = row.Cells["ime"].Value.ToString();
            textBoxprezime.Text = row.Cells["prezime"].Value.ToString();

            comboBoxuloga.SelectedItem =
                row.Cells["uloga"].Value.ToString() == "1" ? "Igrac" :
                row.Cells["uloga"].Value.ToString() == "2" ? "Sudija" :
                "Trener";
        }
        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (selektovanId == -1)
            {
                MessageBox.Show("Izaberi korisnika!");
                return;
            }

            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                string query = @"UPDATE korisnici 
                                 SET email=@email,
                                     sifra=@sifra,
                                     ime=@ime,
                                     prezime=@prezime,
                                     uloga=@uloga
                                 WHERE korisnikid=@id";

                SqlCommand cmd = new SqlCommand(query, veza);

                cmd.Parameters.AddWithValue("@email", textBoxemail.Text);
                cmd.Parameters.AddWithValue("@sifra", textBoxsifra.Text);
                cmd.Parameters.AddWithValue("@ime", textBoxime.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxprezime.Text);
                cmd.Parameters.AddWithValue("@uloga", VratiUlogu());
                cmd.Parameters.AddWithValue("@id", selektovanId);

                cmd.ExecuteNonQuery();
                veza.Close();

                MessageBox.Show("Korisnik izmijenjen!");

                UcitajKorisnike();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (selektovanId == -1)
            {
                MessageBox.Show("Izaberi korisnika!");
                return;
            }

            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM korisnici WHERE korisnikid=@id", veza);

                cmd.Parameters.AddWithValue("@id", selektovanId);

                cmd.ExecuteNonQuery();
                veza.Close();

                MessageBox.Show("Korisnik obrisan!");

                UcitajKorisnike();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonnazad_Click(object sender, EventArgs e)
        {
            Admin1 admin = new Admin1();
            admin.Show();
            this.Hide();
        }
    }
}