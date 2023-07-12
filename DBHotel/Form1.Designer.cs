namespace DBHotel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTamuHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKamarHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataJasaHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1244, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataStaffToolStripMenuItem,
            this.dataTamuHotelToolStripMenuItem,
            this.dataKamarHotelToolStripMenuItem,
            this.dataJasaHotelToolStripMenuItem,
            this.dataHotelToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(106, 24);
            this.toolStripDropDownButton1.Text = "DATA MENU";
            this.toolStripDropDownButton1.ToolTipText = "Menu";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // dataStaffToolStripMenuItem
            // 
            this.dataStaffToolStripMenuItem.Name = "dataStaffToolStripMenuItem";
            this.dataStaffToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.dataStaffToolStripMenuItem.Text = "Data Staff Hotel";
            this.dataStaffToolStripMenuItem.Click += new System.EventHandler(this.dataStaffToolStripMenuItem_Click);
            // 
            // dataTamuHotelToolStripMenuItem
            // 
            this.dataTamuHotelToolStripMenuItem.Name = "dataTamuHotelToolStripMenuItem";
            this.dataTamuHotelToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.dataTamuHotelToolStripMenuItem.Text = "Data Tamu Hotel";
            this.dataTamuHotelToolStripMenuItem.Click += new System.EventHandler(this.dataTamuHotelToolStripMenuItem_Click);
            // 
            // dataKamarHotelToolStripMenuItem
            // 
            this.dataKamarHotelToolStripMenuItem.Name = "dataKamarHotelToolStripMenuItem";
            this.dataKamarHotelToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.dataKamarHotelToolStripMenuItem.Text = "Data Kamar Hotel";
            this.dataKamarHotelToolStripMenuItem.Click += new System.EventHandler(this.dataKamarHotelToolStripMenuItem_Click);
            // 
            // dataJasaHotelToolStripMenuItem
            // 
            this.dataJasaHotelToolStripMenuItem.Name = "dataJasaHotelToolStripMenuItem";
            this.dataJasaHotelToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.dataJasaHotelToolStripMenuItem.Text = "Data Jasa Hotel";
            this.dataJasaHotelToolStripMenuItem.Click += new System.EventHandler(this.dataJasaHotelToolStripMenuItem_Click);
            // 
            // dataHotelToolStripMenuItem
            // 
            this.dataHotelToolStripMenuItem.Name = "dataHotelToolStripMenuItem";
            this.dataHotelToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.dataHotelToolStripMenuItem.Text = "Data Hotel";
            this.dataHotelToolStripMenuItem.Click += new System.EventHandler(this.dataHotelToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBHotel.Properties.Resources.Hotel;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1259, 678);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database Hotel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTamuHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKamarHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataJasaHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataHotelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

