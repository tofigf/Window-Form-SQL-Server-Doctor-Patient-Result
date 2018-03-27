namespace Hekimler
{
    partial class Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd_Soyad = new System.Windows.Forms.TextBox();
            this.lblMuayine = new System.Windows.Forms.Label();
            this.cmbMuayine = new System.Windows.Forms.ComboBox();
            this.lblTarix = new System.Windows.Forms.Label();
            this.btnAnket = new System.Windows.Forms.Button();
            this.lblQebul = new System.Windows.Forms.Label();
            this.txtNomre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDocQebul = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lnlSaat = new System.Windows.Forms.Label();
            this.lblHekiminAdi = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbGunHisse = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYenilemek = new System.Windows.Forms.Button();
            this.btnSilmek = new System.Windows.Forms.Button();
            this.dgwAnket = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.btnNetice = new System.Windows.Forms.Button();
            this.listQiymet = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAnket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAd.Location = new System.Drawing.Point(187, 9);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(66, 15);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad Soyad";
            // 
            // txtAd_Soyad
            // 
            this.txtAd_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAd_Soyad.Location = new System.Drawing.Point(190, 27);
            this.txtAd_Soyad.Multiline = true;
            this.txtAd_Soyad.Name = "txtAd_Soyad";
            this.txtAd_Soyad.Size = new System.Drawing.Size(192, 39);
            this.txtAd_Soyad.TabIndex = 1;
            // 
            // lblMuayine
            // 
            this.lblMuayine.AutoSize = true;
            this.lblMuayine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMuayine.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMuayine.Location = new System.Drawing.Point(431, 9);
            this.lblMuayine.Name = "lblMuayine";
            this.lblMuayine.Size = new System.Drawing.Size(115, 15);
            this.lblMuayine.TabIndex = 8;
            this.lblMuayine.Text = "Muayinenin novu";
            // 
            // cmbMuayine
            // 
            this.cmbMuayine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMuayine.FormattingEnabled = true;
            this.cmbMuayine.Location = new System.Drawing.Point(429, 40);
            this.cmbMuayine.Name = "cmbMuayine";
            this.cmbMuayine.Size = new System.Drawing.Size(163, 26);
            this.cmbMuayine.TabIndex = 9;
            this.cmbMuayine.SelectedIndexChanged += new System.EventHandler(this.cmbMuayine_SelectedIndexChanged);
            // 
            // lblTarix
            // 
            this.lblTarix.AutoSize = true;
            this.lblTarix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTarix.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTarix.Location = new System.Drawing.Point(431, 69);
            this.lblTarix.Name = "lblTarix";
            this.lblTarix.Size = new System.Drawing.Size(39, 15);
            this.lblTarix.TabIndex = 10;
            this.lblTarix.Text = "Tarix";
            // 
            // btnAnket
            // 
            this.btnAnket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnket.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAnket.Location = new System.Drawing.Point(429, 226);
            this.btnAnket.Name = "btnAnket";
            this.btnAnket.Size = new System.Drawing.Size(168, 43);
            this.btnAnket.TabIndex = 15;
            this.btnAnket.Text = "Anket Gondermek";
            this.btnAnket.UseVisualStyleBackColor = true;
            this.btnAnket.Click += new System.EventHandler(this.btnAnket_Click);
            // 
            // lblQebul
            // 
            this.lblQebul.AutoSize = true;
            this.lblQebul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQebul.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQebul.Location = new System.Drawing.Point(-3, 9);
            this.lblQebul.Name = "lblQebul";
            this.lblQebul.Size = new System.Drawing.Size(184, 13);
            this.lblQebul.TabIndex = 18;
            this.lblQebul.Text = "Qebula yazilmaq ucun doldurun";
            // 
            // txtNomre
            // 
            this.txtNomre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNomre.Location = new System.Drawing.Point(190, 164);
            this.txtNomre.Multiline = true;
            this.txtNomre.Name = "txtNomre";
            this.txtNomre.Size = new System.Drawing.Size(192, 39);
            this.txtNomre.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(190, 99);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 39);
            this.txtEmail.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(187, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nomre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(193, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // lblDocQebul
            // 
            this.lblDocQebul.AutoSize = true;
            this.lblDocQebul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocQebul.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDocQebul.Location = new System.Drawing.Point(56, 237);
            this.lblDocQebul.Name = "lblDocQebul";
            this.lblDocQebul.Size = new System.Drawing.Size(49, 15);
            this.lblDocQebul.TabIndex = 25;
            this.lblDocQebul.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(147, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "qebuluna yazilmaq ucun";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(429, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2018, 3, 22, 20, 52, 11, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lnlSaat
            // 
            this.lnlSaat.AutoSize = true;
            this.lnlSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnlSaat.ForeColor = System.Drawing.Color.DarkCyan;
            this.lnlSaat.Location = new System.Drawing.Point(434, 117);
            this.lnlSaat.Name = "lnlSaat";
            this.lnlSaat.Size = new System.Drawing.Size(139, 15);
            this.lnlSaat.TabIndex = 28;
            this.lnlSaat.Text = "Gunun hansi Hissesi";
            // 
            // lblHekiminAdi
            // 
            this.lblHekiminAdi.AutoSize = true;
            this.lblHekiminAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHekiminAdi.ForeColor = System.Drawing.Color.Black;
            this.lblHekiminAdi.Location = new System.Drawing.Point(147, 237);
            this.lblHekiminAdi.Name = "lblHekiminAdi";
            this.lblHekiminAdi.Size = new System.Drawing.Size(0, 18);
            this.lblHekiminAdi.TabIndex = 30;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(39, 317);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 31;
            // 
            // cmbGunHisse
            // 
            this.cmbGunHisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGunHisse.FormattingEnabled = true;
            this.cmbGunHisse.Location = new System.Drawing.Point(434, 135);
            this.cmbGunHisse.Name = "cmbGunHisse";
            this.cmbGunHisse.Size = new System.Drawing.Size(163, 26);
            this.cmbGunHisse.TabIndex = 32;
            this.cmbGunHisse.SelectedIndexChanged += new System.EventHandler(this.cmbGunHisse_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hekimler.Properties.Resources.patient__1_;
            this.pictureBox2.Location = new System.Drawing.Point(687, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hekimler.Properties.Resources.patient;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnYenilemek
            // 
            this.btnYenilemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYenilemek.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnYenilemek.Location = new System.Drawing.Point(150, 385);
            this.btnYenilemek.Name = "btnYenilemek";
            this.btnYenilemek.Size = new System.Drawing.Size(95, 39);
            this.btnYenilemek.TabIndex = 34;
            this.btnYenilemek.Text = " Yenilemek";
            this.btnYenilemek.UseVisualStyleBackColor = true;
            this.btnYenilemek.Visible = false;
            this.btnYenilemek.Click += new System.EventHandler(this.btnYenilemek_Click);
            // 
            // btnSilmek
            // 
            this.btnSilmek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSilmek.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSilmek.Location = new System.Drawing.Point(42, 385);
            this.btnSilmek.Name = "btnSilmek";
            this.btnSilmek.Size = new System.Drawing.Size(105, 39);
            this.btnSilmek.TabIndex = 35;
            this.btnSilmek.Text = "Silmek";
            this.btnSilmek.UseVisualStyleBackColor = true;
            this.btnSilmek.Visible = false;
            this.btnSilmek.Click += new System.EventHandler(this.btnSilmek_Click);
            // 
            // dgwAnket
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAnket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAnket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAnket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwAnket.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwAnket.Location = new System.Drawing.Point(274, 284);
            this.dgwAnket.Name = "dgwAnket";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAnket.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwAnket.Size = new System.Drawing.Size(759, 150);
            this.dgwAnket.TabIndex = 36;
            this.dgwAnket.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwAnket_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "AdSoyad";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nomre";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Muayine";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tarix";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "GununHissesi";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Saat";
            this.Column7.Name = "Column7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(426, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Saat";
            // 
            // cmbSaat
            // 
            this.cmbSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(429, 194);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(163, 26);
            this.cmbSaat.TabIndex = 38;
            // 
            // btnNetice
            // 
            this.btnNetice.BackColor = System.Drawing.Color.Maroon;
            this.btnNetice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNetice.ForeColor = System.Drawing.Color.LightYellow;
            this.btnNetice.Location = new System.Drawing.Point(687, 239);
            this.btnNetice.Name = "btnNetice";
            this.btnNetice.Size = new System.Drawing.Size(337, 39);
            this.btnNetice.TabIndex = 39;
            this.btnNetice.Text = "Neticeni Oyrenmek ucun tiklayin";
            this.btnNetice.UseVisualStyleBackColor = false;
            this.btnNetice.Click += new System.EventHandler(this.btnNetice_Click);
            // 
            // listQiymet
            // 
            this.listQiymet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listQiymet.ForeColor = System.Drawing.Color.Red;
            this.listQiymet.FormattingEnabled = true;
            this.listQiymet.ItemHeight = 15;
            this.listQiymet.Location = new System.Drawing.Point(603, 32);
            this.listQiymet.Name = "listQiymet";
            this.listQiymet.Size = new System.Drawing.Size(78, 34);
            this.listQiymet.TabIndex = 41;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 436);
            this.Controls.Add(this.listQiymet);
            this.Controls.Add(this.btnNetice);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwAnket);
            this.Controls.Add(this.btnSilmek);
            this.Controls.Add(this.btnYenilemek);
            this.Controls.Add(this.cmbGunHisse);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblHekiminAdi);
            this.Controls.Add(this.lnlSaat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDocQebul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNomre);
            this.Controls.Add(this.lblQebul);
            this.Controls.Add(this.btnAnket);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTarix);
            this.Controls.Add(this.cmbMuayine);
            this.Controls.Add(this.lblMuayine);
            this.Controls.Add(this.txtAd_Soyad);
            this.Controls.Add(this.lblAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Patient";
            this.Text = "Patient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Patient_FormClosed);
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAnket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd_Soyad;
        private System.Windows.Forms.Label lblMuayine;
        private System.Windows.Forms.ComboBox cmbMuayine;
        private System.Windows.Forms.Label lblTarix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAnket;
        private System.Windows.Forms.Label lblQebul;
        private System.Windows.Forms.TextBox txtNomre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDocQebul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lnlSaat;
        private System.Windows.Forms.Label lblHekiminAdi;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbGunHisse;
        private System.Windows.Forms.Button btnYenilemek;
        private System.Windows.Forms.Button btnSilmek;
        private System.Windows.Forms.DataGridView dgwAnket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnNetice;
        private System.Windows.Forms.ListBox listQiymet;
    }
}