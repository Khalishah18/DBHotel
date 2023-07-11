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

namespace DBHotel
{
    public partial class Form3 : Form
    {
        private string stringConnection = "data source=LAPTOP-67G15PD7\\LISAA;" + "database=DBHotel; User ID = sa; Password = Lisa18062003";
        private SqlConnection koneksi;
        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_tamu, nm_tamu, nohp, alamat, email, id_staff from dbo.Tamu";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            txtidtm.Text = "";
            txtidtm.Enabled = false;
            txtnm.Text = "";
            txtnm.Enabled = false;
            txtnohp.Text = "";
            txtnohp.Enabled = false;
            txtalmt.Text = "";
            txtalmt.Enabled = false;
            txtemail.Text = "";
            txtemail.Enabled = false;
            txtidstaff.Text = "";
            txtidstaff.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidtm.Enabled = true;
            txtnm.Enabled = true;
            txtnohp.Enabled = true;
            txtalmt.Enabled = true;
            txtemail.Enabled = true;
            txtidstaff.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idtamu = txtidtm.Text;
            string nm = txtnm.Text;
            string nohp = txtnohp.Text;
            string almt = txtalmt.Text;
            string email = txtemail.Text;
            string idstaff = txtidstaff.Text;

            if (idtamu == "")
            {
                MessageBox.Show("Masukkan ID Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nm == "")
            {
                MessageBox.Show("Masukkan Nama Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nohp == "")
            {
                MessageBox.Show("Masukkan Nomor Hp Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (almt == "")
            {
                MessageBox.Show("Masukkan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (email == "")
            {
                MessageBox.Show("Masukkan Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (idstaff == "")
            {
                MessageBox.Show("Masukkan ID Staff", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                koneksi.Open();
                string str = "INSERT INTO Tamu (id_tamu, nm_tamu, nohp, alamat, email, id_staff) VALUES (@id_tamu, @nm_tamu, @nohp, @alamat, @email, @id_staff)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_tamu", idtamu));
                cmd.Parameters.Add(new SqlParameter("@nm_tamu", nm));
                cmd.Parameters.Add(new SqlParameter("@nohp", nohp));
                cmd.Parameters.Add(new SqlParameter("@alamat", almt));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@id_staff", idstaff));
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }
    }
}
