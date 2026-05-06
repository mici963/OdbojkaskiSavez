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
    public partial class Admin2 : Form
    {
        public Admin2()
        {
            InitializeComponent();
        }
        DataTable tabela;
        private void Admin2_Load(object sender, EventArgs e)
        {
            loaddata();
            gridtimovi.DataSource = tabela;

            gridtimovi.Columns["timid"].Visible = false;
            UcitajTrenere();

        }
        private void loaddata()
        {
            SqlConnection veza = Konekcija.Connect();

            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT timid, nazivtima FROM timovi", veza);

            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void gridtimovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            textBoxnazivtima.Text =
                gridtimovi.Rows[e.RowIndex].Cells["nazivtima"].Value.ToString();
        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            if (textBoxnazivtima.Text == "")
            {
                MessageBox.Show("Unesi naziv tima!");
                return;
            }

            if (comboBoxtrener.SelectedValue == null)
            {
                MessageBox.Show("Izaberi trenera!");
                return;
            }

            SqlConnection veza = Konekcija.Connect();

            try
            {
                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO timovi(nazivtima) OUTPUT INSERTED.timid VALUES(@naziv)", veza);

                cmd.Parameters.AddWithValue("@naziv", textBoxnazivtima.Text);

                int noviTimId = (int)cmd.ExecuteScalar();

             
                SqlCommand cmd2 = new SqlCommand(
                    "INSERT INTO treneri(korisnikid, timid) VALUES(@korisnikid, @timid)", veza);

                cmd2.Parameters.AddWithValue("@korisnikid", comboBoxtrener.SelectedValue);
                cmd2.Parameters.AddWithValue("@timid", noviTimId);

                cmd2.ExecuteNonQuery();

                veza.Close();

                MessageBox.Show("Tim i trener uspešno dodati!");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }

            loaddata();
            gridtimovi.DataSource = tabela;
            textBoxnazivtima.Text = "";
        }

        private void buttonobrisi_Click(object sender, EventArgs e)
        {
            if (gridtimovi.CurrentRow == null) return;

            int id = Convert.ToInt32(
                gridtimovi.CurrentRow.Cells["timid"].Value);

            SqlConnection veza = Konekcija.Connect();

            try
            {
                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM timovi WHERE timid=" + id, veza);

                cmd.ExecuteNonQuery();

                veza.Close();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }

            loaddata();
            gridtimovi.DataSource = tabela;
            textBoxnazivtima.Text = "";
        }

        private void Admin2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonnazad_Click(object sender, EventArgs e)
        {
            Admin1 admin = new Admin1();
            admin.Show();
            this.Hide();
        }
        private void UcitajTrenere()
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT korisnikid,
                     ime + ' ' + prezime AS imeprezime
              FROM korisnici
              WHERE uloga = 2", veza);

                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxtrener.DisplayMember = "imeprezime";
                comboBoxtrener.ValueMember = "korisnikid";
                comboBoxtrener.DataSource = dt;

                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
