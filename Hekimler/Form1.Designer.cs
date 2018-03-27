namespace Hekimler
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
            this.lblHekim = new System.Windows.Forms.Label();
            this.lblKlinika = new System.Windows.Forms.Label();
            this.lblSeher = new System.Windows.Forms.Label();
            this.lblSobe = new System.Windows.Forms.Label();
            this.btnAxtaris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTikla = new System.Windows.Forms.Button();
            this.cmbHekim = new System.Windows.Forms.ComboBox();
            this.listKlinika = new System.Windows.Forms.ListBox();
            this.listSeher = new System.Windows.Forms.ListBox();
            this.listSobe = new System.Windows.Forms.ListBox();
            this.ltSexsi_info = new System.Windows.Forms.ListBox();
            this.lblHaqqinda = new System.Windows.Forms.Label();
            this.lblsexsi = new System.Windows.Forms.Label();
            this.ltTehsil = new System.Windows.Forms.ListBox();
            this.ltTecrube = new System.Windows.Forms.ListBox();
            this.ltIxtisas = new System.Windows.Forms.ListBox();
            this.lblTehsil = new System.Windows.Forms.Label();
            this.lblIxtisasi = new System.Windows.Forms.Label();
            this.lblYerler = new System.Windows.Forms.Label();
            this.lblTikla = new System.Windows.Forms.Label();
            this.cmbKlinika = new System.Windows.Forms.ComboBox();
            this.listHekim = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHekim
            // 
            this.lblHekim.AutoSize = true;
            this.lblHekim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHekim.Location = new System.Drawing.Point(12, 2);
            this.lblHekim.Name = "lblHekim";
            this.lblHekim.Size = new System.Drawing.Size(75, 18);
            this.lblHekim.TabIndex = 0;
            this.lblHekim.Text = "Hekimler";
            // 
            // lblKlinika
            // 
            this.lblKlinika.AutoSize = true;
            this.lblKlinika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlinika.Location = new System.Drawing.Point(2, 50);
            this.lblKlinika.Name = "lblKlinika";
            this.lblKlinika.Size = new System.Drawing.Size(177, 17);
            this.lblKlinika.TabIndex = 6;
            this.lblKlinika.Text = "Fealiyyet gosterdiyi yer";
            // 
            // lblSeher
            // 
            this.lblSeher.AutoSize = true;
            this.lblSeher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeher.Location = new System.Drawing.Point(9, 114);
            this.lblSeher.Name = "lblSeher";
            this.lblSeher.Size = new System.Drawing.Size(113, 17);
            this.lblSeher.TabIndex = 8;
            this.lblSeher.Text = "Ishlediyi seher";
            // 
            // lblSobe
            // 
            this.lblSobe.AutoSize = true;
            this.lblSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSobe.Location = new System.Drawing.Point(9, 180);
            this.lblSobe.Name = "lblSobe";
            this.lblSobe.Size = new System.Drawing.Size(57, 17);
            this.lblSobe.TabIndex = 9;
            this.lblSobe.Text = "Ixtisasi";
            // 
            // btnAxtaris
            // 
            this.btnAxtaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAxtaris.Location = new System.Drawing.Point(12, 289);
            this.btnAxtaris.Name = "btnAxtaris";
            this.btnAxtaris.Size = new System.Drawing.Size(110, 50);
            this.btnAxtaris.TabIndex = 13;
            this.btnAxtaris.Text = "Axtarish";
            this.btnAxtaris.UseVisualStyleBackColor = true;
            this.btnAxtaris.Visible = false;
            this.btnAxtaris.Click += new System.EventHandler(this.btnAxtaris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hekimler.Properties.Resources.doctor;
            this.pictureBox1.Location = new System.Drawing.Point(728, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnTikla
            // 
            this.btnTikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTikla.Location = new System.Drawing.Point(590, 266);
            this.btnTikla.Name = "btnTikla";
            this.btnTikla.Size = new System.Drawing.Size(110, 53);
            this.btnTikla.TabIndex = 18;
            this.btnTikla.Text = "Tiklayin!";
            this.btnTikla.UseVisualStyleBackColor = true;
            this.btnTikla.Visible = false;
            this.btnTikla.Click += new System.EventHandler(this.btnTikla_Click);
            // 
            // cmbHekim
            // 
            this.cmbHekim.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbHekim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbHekim.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmbHekim.FormattingEnabled = true;
            this.cmbHekim.Location = new System.Drawing.Point(5, 23);
            this.cmbHekim.Name = "cmbHekim";
            this.cmbHekim.Size = new System.Drawing.Size(157, 24);
            this.cmbHekim.TabIndex = 1;
            this.cmbHekim.SelectedIndexChanged += new System.EventHandler(this.cmbHekim_SelectedIndexChanged);
            this.cmbHekim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbHekim_MouseClick);
            // 
            // listKlinika
            // 
            this.listKlinika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listKlinika.ForeColor = System.Drawing.Color.DarkGreen;
            this.listKlinika.FormattingEnabled = true;
            this.listKlinika.ItemHeight = 15;
            this.listKlinika.Location = new System.Drawing.Point(5, 68);
            this.listKlinika.Name = "listKlinika";
            this.listKlinika.Size = new System.Drawing.Size(150, 49);
            this.listKlinika.TabIndex = 23;
            // 
            // listSeher
            // 
            this.listSeher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSeher.ForeColor = System.Drawing.Color.DarkGreen;
            this.listSeher.FormattingEnabled = true;
            this.listSeher.ItemHeight = 15;
            this.listSeher.Location = new System.Drawing.Point(5, 134);
            this.listSeher.Name = "listSeher";
            this.listSeher.Size = new System.Drawing.Size(150, 19);
            this.listSeher.TabIndex = 24;
            // 
            // listSobe
            // 
            this.listSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSobe.ForeColor = System.Drawing.Color.DarkGreen;
            this.listSobe.FormattingEnabled = true;
            this.listSobe.ItemHeight = 15;
            this.listSobe.Location = new System.Drawing.Point(5, 200);
            this.listSobe.Name = "listSobe";
            this.listSobe.Size = new System.Drawing.Size(150, 19);
            this.listSobe.TabIndex = 25;
            // 
            // ltSexsi_info
            // 
            this.ltSexsi_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltSexsi_info.FormattingEnabled = true;
            this.ltSexsi_info.ItemHeight = 15;
            this.ltSexsi_info.Location = new System.Drawing.Point(541, 68);
            this.ltSexsi_info.Name = "ltSexsi_info";
            this.ltSexsi_info.Size = new System.Drawing.Size(184, 79);
            this.ltSexsi_info.TabIndex = 26;
            this.ltSexsi_info.Visible = false;
            // 
            // lblHaqqinda
            // 
            this.lblHaqqinda.AutoSize = true;
            this.lblHaqqinda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHaqqinda.Location = new System.Drawing.Point(445, 9);
            this.lblHaqqinda.Name = "lblHaqqinda";
            this.lblHaqqinda.Size = new System.Drawing.Size(193, 18);
            this.lblHaqqinda.TabIndex = 28;
            this.lblHaqqinda.Text = "Secdiyiniz hekim haqqda";
            // 
            // lblsexsi
            // 
            this.lblsexsi.AutoSize = true;
            this.lblsexsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsexsi.ForeColor = System.Drawing.Color.Sienna;
            this.lblsexsi.Location = new System.Drawing.Point(538, 50);
            this.lblsexsi.Name = "lblsexsi";
            this.lblsexsi.Size = new System.Drawing.Size(74, 15);
            this.lblsexsi.TabIndex = 29;
            this.lblsexsi.Text = "Sexsi_Info";
            this.lblsexsi.Visible = false;
            // 
            // ltTehsil
            // 
            this.ltTehsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltTehsil.FormattingEnabled = true;
            this.ltTehsil.ItemHeight = 15;
            this.ltTehsil.Location = new System.Drawing.Point(351, 66);
            this.ltTehsil.Name = "ltTehsil";
            this.ltTehsil.Size = new System.Drawing.Size(184, 79);
            this.ltTehsil.TabIndex = 33;
            this.ltTehsil.Visible = false;
            // 
            // ltTecrube
            // 
            this.ltTecrube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltTecrube.FormattingEnabled = true;
            this.ltTecrube.ItemHeight = 15;
            this.ltTecrube.Location = new System.Drawing.Point(351, 169);
            this.ltTecrube.Name = "ltTecrube";
            this.ltTecrube.Size = new System.Drawing.Size(192, 79);
            this.ltTecrube.TabIndex = 34;
            this.ltTecrube.Visible = false;
            // 
            // ltIxtisas
            // 
            this.ltIxtisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltIxtisas.FormattingEnabled = true;
            this.ltIxtisas.ItemHeight = 15;
            this.ltIxtisas.Location = new System.Drawing.Point(541, 169);
            this.ltIxtisas.Name = "ltIxtisas";
            this.ltIxtisas.Size = new System.Drawing.Size(184, 79);
            this.ltIxtisas.TabIndex = 35;
            this.ltIxtisas.Visible = false;
            // 
            // lblTehsil
            // 
            this.lblTehsil.AutoSize = true;
            this.lblTehsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTehsil.ForeColor = System.Drawing.Color.Sienna;
            this.lblTehsil.Location = new System.Drawing.Point(348, 50);
            this.lblTehsil.Name = "lblTehsil";
            this.lblTehsil.Size = new System.Drawing.Size(46, 15);
            this.lblTehsil.TabIndex = 36;
            this.lblTehsil.Text = "Tehsil";
            this.lblTehsil.Visible = false;
            // 
            // lblIxtisasi
            // 
            this.lblIxtisasi.AutoSize = true;
            this.lblIxtisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIxtisasi.ForeColor = System.Drawing.Color.Sienna;
            this.lblIxtisasi.Location = new System.Drawing.Point(538, 151);
            this.lblIxtisasi.Name = "lblIxtisasi";
            this.lblIxtisasi.Size = new System.Drawing.Size(48, 15);
            this.lblIxtisasi.TabIndex = 38;
            this.lblIxtisasi.Text = "Ixtisas";
            this.lblIxtisasi.Visible = false;
            // 
            // lblYerler
            // 
            this.lblYerler.AutoSize = true;
            this.lblYerler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYerler.ForeColor = System.Drawing.Color.Sienna;
            this.lblYerler.Location = new System.Drawing.Point(348, 153);
            this.lblYerler.Name = "lblYerler";
            this.lblYerler.Size = new System.Drawing.Size(84, 15);
            this.lblYerler.TabIndex = 39;
            this.lblYerler.Text = "Iw tecrubesi";
            this.lblYerler.Visible = false;
            // 
            // lblTikla
            // 
            this.lblTikla.AutoSize = true;
            this.lblTikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTikla.Location = new System.Drawing.Point(356, 289);
            this.lblTikla.Name = "lblTikla";
            this.lblTikla.Size = new System.Drawing.Size(228, 18);
            this.lblTikla.TabIndex = 40;
            this.lblTikla.Text = "Qebula yazilmaq ucun buraya";
            this.lblTikla.Visible = false;
            // 
            // cmbKlinika
            // 
            this.cmbKlinika.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbKlinika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbKlinika.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmbKlinika.FormattingEnabled = true;
            this.cmbKlinika.Location = new System.Drawing.Point(185, 23);
            this.cmbKlinika.Name = "cmbKlinika";
            this.cmbKlinika.Size = new System.Drawing.Size(157, 24);
            this.cmbKlinika.TabIndex = 41;
            this.cmbKlinika.SelectedIndexChanged += new System.EventHandler(this.cmbKlinika_SelectedIndexChanged);
            // 
            // listHekim
            // 
            this.listHekim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listHekim.ForeColor = System.Drawing.Color.DarkGreen;
            this.listHekim.FormattingEnabled = true;
            this.listHekim.ItemHeight = 15;
            this.listHekim.Location = new System.Drawing.Point(185, 68);
            this.listHekim.Name = "listHekim";
            this.listHekim.Size = new System.Drawing.Size(150, 49);
            this.listHekim.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1039, 440);
            this.Controls.Add(this.listHekim);
            this.Controls.Add(this.cmbKlinika);
            this.Controls.Add(this.lblTikla);
            this.Controls.Add(this.lblYerler);
            this.Controls.Add(this.lblIxtisasi);
            this.Controls.Add(this.lblTehsil);
            this.Controls.Add(this.ltIxtisas);
            this.Controls.Add(this.ltTecrube);
            this.Controls.Add(this.ltTehsil);
            this.Controls.Add(this.lblsexsi);
            this.Controls.Add(this.lblHaqqinda);
            this.Controls.Add(this.ltSexsi_info);
            this.Controls.Add(this.listSobe);
            this.Controls.Add(this.listSeher);
            this.Controls.Add(this.listKlinika);
            this.Controls.Add(this.btnTikla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAxtaris);
            this.Controls.Add(this.lblSobe);
            this.Controls.Add(this.lblSeher);
            this.Controls.Add(this.lblKlinika);
            this.Controls.Add(this.cmbHekim);
            this.Controls.Add(this.lblHekim);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHekim;
        private System.Windows.Forms.Label lblKlinika;
        private System.Windows.Forms.Label lblSeher;
        private System.Windows.Forms.Label lblSobe;
        private System.Windows.Forms.Button btnAxtaris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTikla;
        private System.Windows.Forms.ComboBox cmbHekim;
        private System.Windows.Forms.ListBox listKlinika;
        private System.Windows.Forms.ListBox listSeher;
        private System.Windows.Forms.ListBox listSobe;
        private System.Windows.Forms.ListBox ltSexsi_info;
        private System.Windows.Forms.Label lblHaqqinda;
        private System.Windows.Forms.Label lblsexsi;
        private System.Windows.Forms.ListBox ltTehsil;
        private System.Windows.Forms.ListBox ltTecrube;
        private System.Windows.Forms.ListBox ltIxtisas;
        private System.Windows.Forms.Label lblTehsil;
        private System.Windows.Forms.Label lblIxtisasi;
        private System.Windows.Forms.Label lblYerler;
        private System.Windows.Forms.Label lblTikla;
        private System.Windows.Forms.ComboBox cmbKlinika;
        private System.Windows.Forms.ListBox listHekim;
    }
}

