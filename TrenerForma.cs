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
    public partial class TrenerForma : Form
    {
        int korisnikid;
        int timid;
        DataTable tabelaUtakmice;
        DataTable tabelaIgraci;

        public TrenerForma(int id)
        {
            InitializeComponent();
            korisnikid = id;
        }

        private void TrenerForma_Load(object sender, EventArgs e)
        {
            uzmitim();

            Loadigraci();
            LoadComboIgraci();

            gridigraci.DataSource = tabelaIgraci;

            gridigraci.ReadOnly = true;
            gridigraci.AllowUserToAddRows = false;
            uzmitim();
            loaddataUtakmice();

            gridutakmice.DataSource = tabelaUtakmice;
            gridigraci.DataSource = tabelaIgraci;
            gridigraci.Columns["korisnikid"].Visible = false;
        }
        private void uzmitim()
        {
            SqlConnection veza = Konekcija.Connect();

            SqlCommand cmd = new SqlCommand(
                "SELECT timid FROM treneri WHERE korisnikid=@id",
                veza
            );

            cmd.Parameters.AddWithValue("@id", korisnikid);

            veza.Open();

            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
                timid = Convert.ToInt32(result);
            else
                MessageBox.Show("Trener nema tim!");

            veza.Close();
        }
        private void loaddataUtakmice()
        {
            SqlConnection veza = Konekcija.Connect();

            SqlCommand cmd = new SqlCommand(
                "SELECT " +
                "td.nazivtima AS domaci_tim, " +
                "tg.nazivtima AS gostujuci_tim, " +
                "u.datum, u.vreme, u.lokacija " +
                "FROM utakmice u " +
                "JOIN timovi td ON u.domacitimid = td.timid " +
                "JOIN timovi tg ON u.gostujucitimid = tg.timid " +
                "WHERE u.domacitimid = @timid OR u.gostujucitimid = @timid",
                veza
            );

            cmd.Parameters.AddWithValue("@timid", timid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            tabelaUtakmice = new DataTable();
            da.Fill(tabelaUtakmice);
        }
        private void Loadigraci()
        {
            SqlConnection veza = Konekcija.Connect();

            SqlCommand cmd = new SqlCommand(
                "SELECT k.korisnikid, k.ime, k.prezime, i.pozicija " +
                "FROM igraci i " +
                "JOIN korisnici k ON i.korisnikid = k.korisnikid " +
                "WHERE i.timid = @timid",
                veza
            );

            cmd.Parameters.AddWithValue("@timid", timid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            tabelaIgraci = new DataTable();
            da.Fill(tabelaIgraci);
        }
        private void LoadComboIgraci()
        {
            SqlConnection veza = Konekcija.Connect();

            SqlCommand cmd = new SqlCommand(
                "SELECT korisnikid, ime + ' ' + prezime AS imeprezime " +
                "FROM korisnici " +
                "WHERE uloga = 1 AND korisnikid NOT IN (SELECT korisnikid FROM igraci)",
                veza
            );

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "imeprezime";
            comboBox1.ValueMember = "korisnikid";
        }
         private void RefreshSve()
        {
            Loadigraci();
            gridigraci.DataSource = null;
            gridigraci.DataSource = tabelaIgraci;

            LoadComboIgraci();
        }
        private void buttondodaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();

            try
            {
                if (comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Izaberi igrača!");
                    return;
                }

                string pozicija = txtPozicija.Text.Trim();

                if (string.IsNullOrWhiteSpace(pozicija))
                {
                    MessageBox.Show("Unesi poziciju!");
                    return;
                }

                int id = Convert.ToInt32(comboBox1.SelectedValue);

                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO igraci(korisnikid, timid, pozicija) VALUES(@id, @timid, @pozicija)",
                    veza
                );

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@timid", timid);
                cmd.Parameters.AddWithValue("@pozicija", pozicija);

                cmd.ExecuteNonQuery();

                veza.Close();

                MessageBox.Show("Igrač dodat u tim!");

                txtPozicija.Clear();
                RefreshSve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Obrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();

            try
            {
                if (gridigraci.CurrentRow == null)
                {
                    MessageBox.Show("Izaberi igrača iz tima!");
                    return;
                }

                int id = Convert.ToInt32(gridigraci.CurrentRow.Cells["korisnikid"].Value);

                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM igraci WHERE korisnikid=@id AND timid=@timid",
                    veza
                );

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@timid", timid);

                cmd.ExecuteNonQuery();

                veza.Close();

                MessageBox.Show("Igrač uklonjen iz tima!");

                RefreshSve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TrenerForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonnazad_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}