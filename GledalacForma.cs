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
    public partial class GledalacForma : Form
    {
        public GledalacForma()
        {
            InitializeComponent();
        }

        DataTable tabela;

        private void GledalacForma_Load(object sender, EventArgs e)
        {
            
            gridgledalac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridgledalac.RowTemplate.Height = 30;
            gridgledalac.DefaultCellStyle.Font = new Font("Arial", 10);
            gridgledalac.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13, FontStyle.Bold);
            loaddata();
            textload();
            gridgledalac.Columns["utakmicaid"].Visible = false;
        }

        private void loaddata()
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();

                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT " +
                    "utakmice.utakmicaid, " +
                    "timovi_domaci.nazivtima AS domaci_tim, " +
                    "timovi_gostujuci.nazivtima AS gostujuci_tim, " +
                    "utakmice.datum, " +
                    "utakmice.vreme, " +
                    "utakmice.lokacija " +
                    "FROM utakmice " +
                    "JOIN timovi AS timovi_domaci ON utakmice.domacitimid = timovi_domaci.timid " +
                    "JOIN timovi AS timovi_gostujuci ON utakmice.gostujucitimid = timovi_gostujuci.timid",
                    veza
                );

                tabela = new DataTable();
                adapter.Fill(tabela);
            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA: " + ex.Message);
            }
        }

        private void textload()
        {
            gridgledalac.DataSource = tabela;
        }

        private void GledalacForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
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