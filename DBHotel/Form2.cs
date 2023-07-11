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
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=LAPTOP-67G15PD7\\LISAA;" + "database=DBHotel; User ID = sa; Password = Lisa18062003";
        private SqlConnection koneksi;
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_Staff, Nama_Staff, Posisi_Staff, No_Hp, Id_Hotel from dbo.Staff";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void refreshform()
        {
            txtIdStaff.Text = "";
            txtIdStaff.Enabled = false;
            txtnmStaff.Text = "";
            txtnmStaff.Enabled = false;
            txtPosisiStaff.Text = "";
            txtPosisiStaff.Enabled = false;
            txtNohpStaff.Text = "";
            txtNohpStaff.Enabled = false;
            txtidhtl.Text = "";
            txtidhtl.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string idstaff = txtIdStaff.Text;
            string nmstaff = txtnmStaff.Text;
            string posisistaff = txtPosisiStaff.Text;
            string nohpstaff = txtNohpStaff.Text;
            string idhotel = txtidhtl.Text;

            if (idstaff == "")
            {
                MessageBox.Show("Masukkan ID Staff ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nmstaff == "")
            {
                MessageBox.Show("Masukkan Nama Staff ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (posisistaff == "")
            {
                MessageBox.Show("Masukkan Posisi Staff ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nohpstaff == "")
            {
                MessageBox.Show("Masukkan Nomor Hp Staff ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (idhotel == "")
            {
                MessageBox.Show("Masukkan ID Hotel ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                koneksi.Open();
                string str = "INSERT INTO Staff (id_Staff, Nama_Staff, Posisi_Staff, No_Hp, Id_Hotel) VALUES (@id_Staff, @Nama_Staff, @Posisi_Staff, @No_Hp, @Id_Hotel";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_Staff", idstaff));
                cmd.Parameters.Add(new SqlParameter("@Nama_Staff", nmstaff));
                cmd.Parameters.Add(new SqlParameter("@Posisi_Staff", posisistaff));
                cmd.Parameters.Add(new SqlParameter("@No_Hp", nohpstaff));
                cmd.Parameters.Add(new SqlParameter("@id_Hotel", idhotel));
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

        private void button5_Click(object sender, EventArgs e)
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

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }
    }
}
