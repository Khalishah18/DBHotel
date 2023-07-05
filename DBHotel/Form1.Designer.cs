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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // dataStaffToolStripMenuItem
            // 
            this.dataStaffToolStripMenuItem.Name = "dataStaffToolStripMenuItem";
            this.dataStaffToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataStaffToolStripMenuItem.Text = "Data Staff Hotel";
            // 
            // dataTamuHotelToolStripMenuItem
            // 
            this.dataTamuHotelToolStripMenuItem.Name = "dataTamuHotelToolStripMenuItem";
            this.dataTamuHotelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataTamuHotelToolStripMenuItem.Text = "Data Tamu Hotel";
            // 
            // dataKamarHotelToolStripMenuItem
            // 
            this.dataKamarHotelToolStripMenuItem.Name = "dataKamarHotelToolStripMenuItem";
            this.dataKamarHotelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataKamarHotelToolStripMenuItem.Text = "Data Kamar Hotel";
            // 
            // dataJasaHotelToolStripMenuItem
            // 
            this.dataJasaHotelToolStripMenuItem.Name = "dataJasaHotelToolStripMenuItem";
            this.dataJasaHotelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataJasaHotelToolStripMenuItem.Text = "Data Jasa Hotel";
            // 
            // dataHotelToolStripMenuItem
            // 
            this.dataHotelToolStripMenuItem.Name = "dataHotelToolStripMenuItem";
            this.dataHotelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataHotelToolStripMenuItem.Text = "Data Hotel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}

