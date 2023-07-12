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
    public partial class Form5 : Form
    {

        private string stringConnection = "data source=LAPTOP-67G15PD7\\LISAA;" + "database=DBHotel; User ID = sa; Password = Lisa18062003";
        private SqlConnection koneksi;

        BindingSource JasaBindingSource = new BindingSource();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            txtIdJasa.Enabled = true;
            txtNamaJasa.Enabled = true;
            txtHrgJasa.Enabled = true;
            cmbidkmr.Enabled = true;
            IdKamar();
            btnClear.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string IdJasa = txtIdJasa.Text;
            string NamaJasa = txtNamaJasa.Text;
            string HargaJasa = txtHrgJasa.Text;
            string IdKamar = cmbidkmr.Text;

            if (IdJasa == "")
            {
                MessageBox.Show("Masukkan Id Jasa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (NamaJasa == "")
            {
                MessageBox.Show("Masukkan Nama Jasa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (HargaJasa == "")
            {
                MessageBox.Show("Masukkan Harga Jasa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (IdKamar == "")
            {
                MessageBox.Show("Masukkan Id Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Jasa (Id_Jasa, Nama_Jasa, Harga_Jasa, Id_Kamar) VALUES (@Id_Jasa, @Nama_Jasa, @Harga_Jasa, @Id_Kamar)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_Jasa", IdJasa));
                cmd.Parameters.Add(new SqlParameter(" @Nama_Jasa", NamaJasa));
                cmd.Parameters.Add(new SqlParameter("@Harga_Jasa", HargaJasa));
                cmd.Parameters.Add(new SqlParameter("@Id_Kamar", IdKamar));
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void IdKamar()
        {
            koneksi.Open();
            string str = "select Id_Kamar from dbo.Kamar";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
            cmbidkmr.ValueMember = "Id_Kamar";
            cmbidkmr.DataSource = ds.Tables[0];
        }
        public Form5()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
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

        private void Form5_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT Id_Jasa, Nama_Jasa, Harga_Jasa, Id_Kamar FROM Jasa", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.JasaBindingSource.DataSource = ds.Tables[0];
            this.txtIdJasa.DataBindings.Add(
                new Binding("Text", this.JasaBindingSource, "ID_Jasa", true)); ;
            this.txtNamaJasa.DataBindings.Add(
                new Binding("Text", this.JasaBindingSource, "Nama_Jasa", true));
            this.txtHrgJasa.DataBindings.Add(
                new Binding("Text", this.JasaBindingSource, "Harga_Jasa", true));
            this.cmbidkmr.DataBindings.Add(
                new Binding("Text", this.JasaBindingSource, "Id_Kamar", true));
            koneksi.Close();
            refreshform();
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
            cmbidkmr.Enabled = false;
            cmbidkmr.SelectedIndex = -1;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void cmbidkmr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
