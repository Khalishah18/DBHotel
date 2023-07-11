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
    public partial class Form4 : Form
    {
        private string stringConnection = "data source=LAPTOP-67G15PD7\\LISAA;" + "database=DBHotel; User ID = sa; Password = Lisa18062003";
        private SqlConnection koneksi;

        private string Id_Kamar, Jenis_Kamar, Status_Kamar, Fasilitas_Kamar, Id_Tamu;

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
          
        }

        BindingSource customersBindingSource = new BindingSource();
        public Form4()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Id_Kamar = dataGridView1.SelectedRows[0].Cells["Id_Kamar"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Kamar WHERE Id_Kamar = @Id_Kamar";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@Id_Kamar", Id_Kamar);
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtIdKamar.Text = "";
            txtIdKamar.Enabled = true;
            txtjnskmr.Text = "";
            txtjnskmr.Enabled = true;
            txtSttsKmr.Text = "";
            txtSttsKmr.Enabled = true;
            txtfasilitaskmr.Text = "";
            txtfasilitaskmr.Enabled = true;
            txtidtamu.Text = "";
            txtidtamu.Enabled = true;
            btnclear.Enabled = true;
            btnsave.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string IdKamar = txtIdKamar.Text;
            string JenisKamar = txtjnskmr.Text;
            string Status_Kamar = txtSttsKmr.Text;
            string Fasilitas_Kamar = txtfasilitaskmr.Text;
            string Id_Tamu = txtidtamu.Text;


            if (IdKamar == "")
            {
                MessageBox.Show("Masukkan ID Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (JenisKamar == "")
            {
                MessageBox.Show("Masukkan Jenis Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (Status_Kamar == "")
            {
                MessageBox.Show("Masukkan Status Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Fasilitas_Kamar == "")
            {
                MessageBox.Show("Masukkan Fasilitas Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Id_Tamu == "")
            {
                MessageBox.Show("Masukkan ID Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                koneksi.Open();
                string str = "INSERT INTO Kamar (Id_Kamar, Jenis_Kamar, Status_Kamar, Fasilitas_Kamar, Id_Tamu) VALUES (@Id_Kamar, @Jenis_Kamar, @Status_Kamar, @Fasilitas_Kamar, @Id_Tamu)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_Kamar", IdKamar));
                cmd.Parameters.Add(new SqlParameter("@Jenis_Kamar", JenisKamar));
                cmd.Parameters.Add(new SqlParameter("@Status_Kamar", Status_Kamar));
                cmd.Parameters.Add(new SqlParameter("@Fasilitas_Kamar", Fasilitas_Kamar));
                cmd.Parameters.Add(new SqlParameter("@Id_Tamu", Id_Tamu));
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void cmbIdTamu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select Id_Kamar, Jenis_Kamar, Status_Kamar, Fasilitas_Kamar, Id_Tamu from dbo.Kamar";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
      
        private void refreshform()
        {

            txtIdKamar.Enabled = false;
            txtjnskmr.Enabled = false;
            txtSttsKmr.Enabled = false;
            txtfasilitaskmr.Enabled = false;
            txtidtamu.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

    }
}
