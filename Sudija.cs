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
    public partial class Sudija : Form
    {
        private int korisnikId;
        private int sudijaId;
        private int selektovanaUtakmicaId = -1;

        public Sudija(int id)
        {
            InitializeComponent();
            korisnikId = id;
        }
      private void Sudija_Load(object sender, EventArgs e)
        {
          
            UcitajsudijaId();
            Ucitajtimove();
            Ucitajutakmice();
       
        }
        private void UcitajsudijaId()
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT sudijaid FROM sudije WHERE korisnikid=@kid", veza);

                cmd.Parameters.AddWithValue("@kid", korisnikId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                    sudijaId = Convert.ToInt32(result);

                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ucitajtimove()
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT timid, nazivtima FROM timovi", veza);

                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxDomaci.DisplayMember = "nazivtima";
                comboBoxDomaci.ValueMember = "timid";
                comboBoxDomaci.DataSource = dt;

                comboBoxGosti.DisplayMember = "nazivtima";
                comboBoxGosti.ValueMember = "timid";
                comboBoxGosti.DataSource = dt.Copy();

                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
     private void Ucitajutakmice()
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT u.utakmicaid,
                             u.domacitimid,
                             u.gostujucitimid,
                             t1.nazivtima AS Domaci,
                             t2.nazivtima AS Gosti,
                             u.datum,
                             u.vreme,
                             u.lokacija
                      FROM utakmice u
                      JOIN timovi t1 ON u.domacitimid = t1.timid
                      JOIN timovi t2 ON u.gostujucitimid = t2.timid
                      WHERE u.sudijaid = @sid", veza);

                da.SelectCommand.Parameters.AddWithValue("@sid", sudijaId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridutakmice.DataSource = dt;
                gridutakmice.Columns["utakmicaid"].Visible = false;
                gridutakmice.Columns["domacitimid"].Visible = false;
                gridutakmice.Columns["gostujucitimid"].Visible = false;

                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
        private void buttoinDodajUtakmicu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();
                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO utakmice
                    (domacitimid, gostujucitimid, datum, vreme, lokacija, sudijaid)
                    VALUES
                    (@domaci, @gosti, @datum, @vreme, @lokacija, @sid)", veza);

                cmd.Parameters.AddWithValue("@domaci", comboBoxDomaci.SelectedValue);
                cmd.Parameters.AddWithValue("@gosti", comboBoxGosti.SelectedValue);
                cmd.Parameters.AddWithValue("@datum", dateTimePickerDatum.Value.Date);
                cmd.Parameters.AddWithValue("@vreme", textBoxVreme.Text);
                cmd.Parameters.AddWithValue("@lokacija", textBoxLokacija.Text);
                cmd.Parameters.AddWithValue("@sid", sudijaId);

                cmd.ExecuteNonQuery();
                veza.Close();

                Ucitajutakmice();
                MessageBox.Show("Utakmica dodata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sudija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonnazad_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
    }
