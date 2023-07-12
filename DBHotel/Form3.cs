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

        BindingSource TamuBindingSource = new BindingSource();
        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select Id_Tamu,Nama_Tamu,No_Hp,Alamat,Email,Id_Staff from dbo.Tamu";
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
            cmbidstaff.Enabled = false;
            cmbidstaff.SelectedIndex = -1;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;
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
            cmbidstaff.Enabled = true;
            IdStaff();
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void IdStaff()
        {
            koneksi.Open();
            string str = "select Id_Staff from dbo.Staff";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
            cmbidstaff.ValueMember = "Id_Staff";
            cmbidstaff.DataSource = ds.Tables[0];
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idtamu = txtidtm.Text;
            string nm = txtnm.Text;
            string nohp = txtnohp.Text;
            string almt = txtalmt.Text;
            string email = txtemail.Text;
            string idstaff = cmbidstaff.Text;

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
                string str = "INSERT INTO Tamu (Id_Tamu,Nama_Tamu,No_Hp,Alamat,Email,Id_Staff) VALUES (@Id_Tamu,@Nama_Tamu,@No_Hp,@Alamat,@Email,@Id_Staff)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_Tamu", idtamu));
                cmd.Parameters.Add(new SqlParameter("@Nama_Tamu", nm));
                cmd.Parameters.Add(new SqlParameter("@No_Hp", nohp));
                cmd.Parameters.Add(new SqlParameter("@Alamat", almt));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@Id_Staff", idstaff));
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Nama_Tamu = dataGridView1.SelectedRows[0].Cells["Nama_Tamu"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Tamu WHERE Nama_Tamu = @Nama_Tamu";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@Nama_Tamu", Nama_Tamu);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                }
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
