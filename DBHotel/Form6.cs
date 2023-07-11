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
    public partial class Form6 : Form
    {
        private string stringConnection = "data source=LAPTOP-67G15PD7\\LISAA;" + "database=DBHotel; User ID = sa; Password = Lisa18062003";
        private SqlConnection koneksi;

        private string idhtl, nmhtl, almt, notelp;

        public Form6()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idhtl = txtidhtl.Text;
            string nmhtl = txtnmhtl.Text;
            string almt = txtalmthtl.Text;
            string notelp = txtnotelp.Text;


            if (idhtl == "")
            {
                MessageBox.Show("Masukkan ID Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nmhtl == "")
            {
                MessageBox.Show("Masukkan Nama Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (almt == "")
            {
                MessageBox.Show("Masukkan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (notelp == "")
            {
                MessageBox.Show("Masukkan Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                koneksi.Open();
                string str = "INSERT INTO Hotel (Id_Hotel, Nama_Hotel, Alamat_Hotel, No_Telp) VALUES (@Id_Hotel, @Nama_Hotel, @Alamat_Hotel, @No_Telp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_Hotel", idhtl));
                cmd.Parameters.Add(new SqlParameter("@Nama_Hotel", nmhtl));
                cmd.Parameters.Add(new SqlParameter("@Alamat_Hotel", almt));
                cmd.Parameters.Add(new SqlParameter("@No_Telp", notelp));
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Nama_Hotel = dataGridView1.SelectedRows[0].Cells["Nama_Hotel"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Hotel WHERE Nama_Hotel = @Nama_Hotel";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@Nama_Hotel", Nama_Hotel);
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

        private void Form6_Load(object sender, EventArgs e)
        {
            refreshform();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtidhtl.Text = "";
            txtnmhtl.Text = "";
            txtalmthtl.Text = "";
            txtnotelp.Text = "";
            txtidhtl.Enabled = true;
            txtnmhtl.Enabled = true;
            txtalmthtl.Enabled = true;
            txtnotelp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select Id_Hotel, Nama_Hotel, Alamat_Hotel, No_Telp from dbo.Hotel";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void refreshform()
        {
            txtidhtl.Text = "";
            txtidhtl.Enabled = false;
            txtnmhtl.Text = "";
            txtnmhtl.Enabled = false;
            txtalmthtl.Text = "";
            txtalmthtl.Enabled = false;
            txtnotelp.Text = "";
            txtnotelp.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

    }
}
