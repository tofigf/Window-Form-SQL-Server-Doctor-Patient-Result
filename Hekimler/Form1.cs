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

namespace Hekimler
{
    public partial class Form1 : Form
    {
        public static string passingText;
        private SqlConnection con = new SqlConnection("Data Source = USER-ПК; Initial Catalog =Tebibler; Integrated Security = SSPI");

        public Form1()
        {
            InitializeComponent();
            FillHekimCombo();
            FillKlinikaCombo();
        }
        //hekimler
        private void FillHekimCombo()
        {
            con.Open();

            string query = "SELECT *FROM Hekimler";

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbHekim.Items.Add(reader.GetString(1));
            }
            con.Close();
        }
        //klinika
        private void FillKlinikaCombo()
        {
            con.Open();

            string query = "SELECT *FROM klinika";

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbKlinika.Items.Add(reader.GetString(1));
            }
            con.Close();

        }
        //butun itemlerin bos olmasi ve temizlenmesi
        private void AllItemsClears()
        {
        
            listKlinika.Items.Clear();
            listSeher.Items.Clear();
            listSobe.Items.Clear();
            ltTecrube.Items.Clear();
            ltTehsil.Items.Clear();
            ltSexsi_info.Items.Clear();
            ltIxtisas.Items.Clear();
            listSobe.Text = "";
            listSeher.Text = "";
            listKlinika.Text = "";
            ltIxtisas.Text = "";
            ltSexsi_info.Text = "";
            ltTecrube.Text = "";
            ltTehsil.Text = "";

        }
        //=========================
        //hekimin infosu gorsenmir
        private void DisapperDoctorsInfo()
        {
            btnAxtaris.Visible = true;
            btnTikla.Visible = false;
            lblTikla.Visible = false;
            ltTehsil.Visible = false;
            ltTecrube.Visible = false;
            ltSexsi_info.Visible = false;
            ltIxtisas.Visible = false;
            lblIxtisasi.Visible = false;
            lblsexsi.Visible = false;
            lblTehsil.Visible = false;
            lblYerler.Visible = false;

        }
        //hekimin infosunu gostermek
        private void AppearsDoctorsInfo()
        {
            btnAxtaris.Visible = false;
            btnTikla.Visible = true;
            lblTikla.Visible = true;
            ltTehsil.Visible = true;
            ltTecrube.Visible = true;
            ltSexsi_info.Visible = true;
            ltIxtisas.Visible = true;
            lblIxtisasi.Visible = true;
            lblsexsi.Visible = true;
            lblTehsil.Visible = true;
            lblYerler.Visible = true;

        }
        //==========================
        //hekimin adlarinin secimi zamani gelen infolar
        private void cmbHekim_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisapperDoctorsInfo();
            string hekim = cmbHekim.Text;
            con.Open();
            string query = "SELECT kl.Ad,sh.Ad,sob.Ad,it.IsTecrubesi,ix.Haqqinda,si.Haqqinda,th.Haqqinda " +
                                  " FROM Hekimler hk " +
                 " INNER JOIN Hekim_Klinika hkl ON hkl.Hekim_ID = hk.id "+
                 " INNER JOIN klinika kl ON kl.Id = hkl.Klnika_ID "+
                "INNER JOIN Seherler sh ON hk.sherlerId = sh.Id " +
                 "INNER JOIN Sobeler sob ON hk.sobeId = sob.id " +
                " INNER JOIN IsTecrubesi it ON hk.IsTecrubesi_ID = it.ID " +
                " INNER JOIN Ixtisas ix ON hk.Ixtisas_ID = ix.ID " +
                " INNER JOIN Sexsi_Info si ON hk.Sexsi_Info_ID = si.ID " +
                 " INNER JOIN Tehsil th ON hk.Tehsil_ID = th.ID " +

                           "WHERE hk.ad= '" + hekim + "'";
            AllItemsClears();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listKlinika.Items.Add(reader.GetString(0));
                 listSeher.Items.Add(reader.GetString(1));
                listSobe.Items.Add(reader.GetString(2));
                ltTecrube.Items.Add(reader.GetString(3));
                ltIxtisas.Items.Add(reader.GetString(4));
                ltSexsi_info.Items.Add(reader.GetString(5));
                ltTehsil.Items.Add(reader.GetString(6));
            }

            con.Close();


        }
        //==========================
        //axtariw duymesinde hekimin infosunu gosteririk
        private void btnAxtaris_Click(object sender, EventArgs e)
        {
            AppearsDoctorsInfo();
            passingText = cmbHekim.Text;
        }
        //patient sehifesine kecmek ucun
        private void btnTikla_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Hide();
        }
        //proqrami baglamaq ucun
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //hekim comboboxa basanda axtariw duymesi peyda olur
        private void cmbHekim_MouseClick(object sender, MouseEventArgs e)
        {

            btnAxtaris.Visible = true;
        }
        //klinkani scende hekmileri gosterir
        private void cmbKlinika_SelectedIndexChanged(object sender, EventArgs e)
        {
            string klinika = cmbKlinika.Text;
            con.Open();
            string query = "SELECT h.Ad "+
                                    "FROM klinika kl "+
                                   "INNER JOIN Hekim_Klinika hk ON hk.Klnika_ID = kl.Id "+
                                   "INNER JOIN Hekimler h ON h.id = hk.Hekim_ID "+         
                                      "WHERE kl.Ad = '" + klinika + "'";
            listHekim.Items.Clear();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listHekim.Items.Add(reader.GetString(0));
            }
            con.Close();
        }
    }
}
