using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 stf = new Form2();
            stf.Show();
            this.Hide();

        }

        private void dataTamuHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tm = new Form3();
            tm.Show();
            this.Hide();
        }

        private void dataKamarHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 kmr = new Form4();
            kmr.Show();
            this.Hide();
        }

        private void dataJasaHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 js = new Form5();
            js.Show();
            this.Hide();
        }

        private void dataHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 htl = new Form6();
            htl.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
