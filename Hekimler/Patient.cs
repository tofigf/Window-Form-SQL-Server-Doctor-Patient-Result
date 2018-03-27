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
using System.Text.RegularExpressions;

namespace Hekimler
{
    public partial class Patient : Form
    {
        public static string patientText;
        public static string muayineText;
        public static string qiymetText;
        private SqlConnection con = new SqlConnection("Data Source = USER-ПК; Initial Catalog =Tebibler; Integrated Security = SSPI");
        
        private int ClickedId = 0;
        public Patient()
        {
            InitializeComponent();
            FillSortOfCheck();
            FillDataPart();
            FillTime();
           FillAnketGrid();
            }
        //closed edende sehifenin temiz baglanmasi
        private void Patient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //tarixin datasini oxumaq
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dates = this.dateTimePicker1.Value;
            string date = dates.ToString("yyyy-MM-dd");
            

           
        }
        //datgridview icini doldurmaq
        private void FillAnketGrid()
        {
            dgwAnket.Rows.Clear();
            con.Open();

            string query =
                               "SELECT Anket.ID, Anket.Ad_Soyad, Anket.Email, Anket.Nomre, mua.Novu ,Anket.DateTimePicker , gun.Hisse ,st.Vaxtlar " +
                                 "FROM Anket " +
                           "INNER JOIN Muayine mua ON Anket.Muayine_ID = mua.ID " +
                         " INNER JOIN Saat st ON Anket.Saat_ID = st.ID " +
                        " INNER JOIN Gunun_Hissesi gun ON st.Gunun_ID = gun.ID ";


            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                dgwAnket.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetDateTime(5),reader.GetString(6),reader.GetString(7));
            }
            con.Close();
        }
        private void cmbGunHisse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSaat.Items.Clear();
            cmbSaat.Text = "";
            string gun_hisse = cmbGunHisse.Text;
            con.Open();
            string query =
                              "SELECT st.Vaxtlar FROM Saat st " +
                               "INNER JOIN Gunun_Hissesi gun ON st.Gunun_ID = gun.ID " +
                              "WHERE gun.Hisse = '" + gun_hisse + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbSaat.Items.Add(reader.GetString(0));
            }

            con.Close();
        }
        //hekimin adini patient sehifesinde cigartmaq
        private void Patient_Load(object sender, EventArgs e)
        {
            lblHekiminAdi.Text = Form1.passingText;
       
          
         
        }
        //muayineni combaboxa doldurmaq
        private void FillSortOfCheck()
        {
            con.Open();
            string query = "SELECT *FROM Muayine";
            SqlCommand command = new SqlCommand(query,con);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                cmbMuayine.Items.Add(reader.GetString(1));
            }

            con.Close();
        }
        //saati comboxa doldurmaq
        private void FillTime()
        {
            con.Open();
            string query = "SELECT * FROM Saat";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbSaat.Items.Add(reader.GetString(1));
            }
            con.Close();

        }
        //gunun hissesini comboboxa doldurmaq
        private void FillDataPart()
        {
            con.Open();
            string query = "SELECT * FROM Gunun_Hissesi";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbGunHisse.Items.Add(reader.GetString(1));
            }
            con.Close();

        }
        //xanalari bowaltmaq
        private void Reset()
        {
            FillAnketGrid();
            txtAd_Soyad.Text = "";
            txtEmail.Text = "";
            txtNomre.Text = "";
            listQiymet.Text = "";
            lblError.Text = "";
            cmbMuayine.Text = "";
            cmbGunHisse.Text = "";
            cmbSaat.Text = "";

        }
        //ankete click 
        private void btnAnket_Click(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{2}\s+[0-9]{3}\s+[0-9]{4}");
            if (phoneNumpattern.IsMatch(txtNomre.Text))
            {  
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
            
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("@ isaresini yazmaq mutleqdir");
            }
            patientText = txtAd_Soyad.Text;
            muayineText = cmbMuayine.Text;
            qiymetText = listQiymet.Text;
           DateTime dates = dateTimePicker1.Value;
            string date = dates.ToString("yyyy-MM-dd");
            string ad_Soyad = txtAd_Soyad.Text;
            string Email = txtEmail.Text;
            string Nomre = txtNomre.Text;
            string muayine = cmbMuayine.Text;
            string time = cmbSaat.Text;
            if (ad_Soyad == "" || Email == "" || Nomre == "")
            {
                lblError.Text = "Butun Xanalari Doldurun!";
                return;
            }
            string query = "INSERT INTO Anket(Ad_Soyad,Email, Nomre, Muayine_ID, Saat_ID ,DateTimePicker)" +
                                      " VALUES('"+ad_Soyad + "','"+Email+"','"+Nomre+"','"+ GetMuayineIdName (muayine) + "','"+ GetDayTime ( time ) + "','"+date+"')";
          
            con.Open();
            

            SqlCommand command = new SqlCommand(query,con);
            int af = command.ExecuteNonQuery();

            con.Close();
            Reset();
        }
        //muayinin id
        private int GetMuayineIdName(string muayine)

        {
            con.Open();
            string query = " SELECT ID FROM Muayine WHERE Novu='"+ muayine +"'";

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            int ID = 0;
            while(reader.Read())
            {
                ID = reader.GetInt32(0);
            }
            con.Close();
            return  ID;

        }
        //gun hissesi id
        private int GetDayTime(string time)
        {
            con.Open();
            string query = "SELECT ID FROM Saat WHERE Vaxtlar='" + time + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            int ID = 0;
            while (reader.Read())
            {
                ID = reader.GetInt32(0);
            }
            con.Close();
            return ID;
        }
        // datagridview rows clickinde id sini bilmek
        private void dgwAnket_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSilmek.Visible = true;
            btnYenilemek.Visible = true;
            ClickedId = Convert.ToInt32(dgwAnket.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtAd_Soyad.Text =dgwAnket.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgwAnket.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNomre.Text = dgwAnket.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbMuayine.Text = dgwAnket.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker1.Text = dgwAnket.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbGunHisse.Text = dgwAnket.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbSaat.Text = dgwAnket.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        //silmek
        private void btnSilmek_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Eminsiniz?", "silmeye", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                con.Open();
                string query = "DELETE FROM Anket WHERE ID =" + ClickedId;
                SqlCommand command = new SqlCommand(query, con);
                int af = command.ExecuteNonQuery();
                con.Close();
                Reset();
            }
        }
        //yenilemek
        private void btnYenilemek_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string ad_Soyad = txtAd_Soyad.Text;
            string Email = txtEmail.Text;
            string Nomre = txtNomre.Text;
            //string Sigorta = rbtnSigorta.Text;
            string muayine = cmbMuayine.Text;
            string time = cmbSaat.Text;
            if (ad_Soyad == "" || Email == "" || Nomre == "")
            {
                lblError.Text = "Fill up All sections";
                return;
            }
            string query = "UPDATE Anket SET Ad_Soyad ='" + ad_Soyad + "',Email='" + Email + "', Nomre='" + Nomre + "',  Muayine_ID =  '" + GetMuayineIdName(muayine)+ "',Gun_Hisse_ID='" + GetDayTime(time) + "' ,DateTimePicker='" + date  +"'  WHERE ID =" + this.ClickedId;

            con.Open();


            SqlCommand command = new SqlCommand(query, con);
            int af = command.ExecuteNonQuery();

            con.Close();
            Reset();
        }
        //netice sehifesine kecid
        private void btnNetice_Click(object sender, EventArgs e)
        {

            Netice net =new Netice();
            net.Show();
            this.Hide();
        }
       // muayinenin qiymetini bilmek
        private void cmbMuayine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string muayine = cmbMuayine.Text;
            con.Open();


            string query = "SELECT qy.Qiymetler " +
                           "FROM Muayine my " +
                              " INNER JOIN Qiymet qy ON my.Qiymet_ID = qy.ID "+
                              "WHERE my.Novu= '" + muayine + "'";
            listQiymet.Text = "";
            listQiymet.Items.Clear();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listQiymet.Items.Add(reader.GetString(0));
            }
            con.Close();
          
        }
    }
}
