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
    public partial class btnBack : Form
    {
        private string stringConnection = "data source=LAPTOP-67G15PD7\\LISAA;" + "database=DBHotel; User ID = sa; Password = Lisa18062003";
        private SqlConnection koneksi;

        private string Id_Jasa, Nama_Jasa, Harga_Jasa, Id_Kamar;
        BindingSource customersBindingSource = new BindingSource();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdJasa.Text = "";
            txtIdJasa.Enabled = true;
            txtNamaJasa.Text = "";
            txtNamaJasa.Enabled = true;
            txtHrgJasa.Text = "";
            txtHrgJasa.Enabled = true;
            txtIdkmr.Text = "";
            txtIdkmr.Enabled = true;
            btnClear.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string IdJasa = txtIdJasa.Text;
            string NamaJasa = txtNamaJasa.Text;
            string HargaJasa = txtHrgJasa.Text;
            string IdKamar = txtIdkmr.Text;

            if (Id_Jasa == "")
            {
                MessageBox.Show("Masukkan Id Jasa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Nama_Jasa == "")
            {
                MessageBox.Show("Masukkan Nama Jasa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Harga_Jasa == "")
            {
                MessageBox.Show("Masukkan Harga Jasa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Id_Kamar == "")
            {
                MessageBox.Show("Masukkan Id Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Jasa(Id_Jasa, Nama_Jasa, Harga_Jasa, Id_Kamar) VALUES (@Id_Jasa, @Nama_Jasa, @Harga_Jasa, @Id_Kamar)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_Jasa", Id_Jasa));
                cmd.Parameters.Add(new SqlParameter(" @Nama_Jasa", Nama_Jasa));
                cmd.Parameters.Add(new SqlParameter("@Harga_Jasa", Harga_Jasa));
                cmd.Parameters.Add(new SqlParameter("@Id_Kamar", Id_Kamar));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        public btnBack()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Nama_Jasa = dataGridView1.SelectedRows[0].Cells["Nama_Jasa"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Jasa WHERE Nama_Jasa = @Nama_Jasa";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@Nama_Jasa", Nama_Jasa);
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

        private void btnBack_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "Select Id_Jasa, Nama_Jasa, Harga_Jasa, Id_Kamar from dbo.Jasa";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void refreshform()
        {
            txtIdJasa.Text = "";
            txtIdJasa.Enabled = false;
            txtNamaJasa.Text = "";
            txtNamaJasa.Enabled = false;
            txtHrgJasa.Text = "";
            txtHrgJasa.Enabled = false;
            txtIdkmr.Text = "";
            txtIdkmr.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
    }
}
