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
    public partial class Netice : Form
    {
        private SqlConnection con = new SqlConnection("Data Source = USER-ПК; Initial Catalog =Tebibler; Integrated Security = SSPI");
        public Netice()
        {
            InitializeComponent();
        }

        private void Netice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Netice_Load(object sender, EventArgs e)
        {
            lblPatient.Text = Patient.patientText;
            lblDoc_net.Text= Form1.passingText;
            lblMualice.Text = Patient.muayineText;
           // listQiymetAzn.Text = Patient.qiymetText;

        }
    }
}
