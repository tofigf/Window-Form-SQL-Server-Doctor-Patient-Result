namespace Hekimler
{
    partial class Netice
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
            this.lblNetice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoc_net = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblMualice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNetice
            // 
            this.lblNetice.AutoSize = true;
            this.lblNetice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNetice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNetice.Location = new System.Drawing.Point(263, 30);
            this.lblNetice.Name = "lblNetice";
            this.lblNetice.Size = new System.Drawing.Size(342, 39);
            this.lblNetice.TabIndex = 0;
            this.lblNetice.Text = "Muayinenin Neticesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient";
            // 
            // lblDoc_net
            // 
            this.lblDoc_net.AutoSize = true;
            this.lblDoc_net.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDoc_net.Location = new System.Drawing.Point(148, 132);
            this.lblDoc_net.Name = "lblDoc_net";
            this.lblDoc_net.Size = new System.Drawing.Size(0, 20);
            this.lblDoc_net.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mualicenin novu ::";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(382, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mualice olundu.";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatient.Location = new System.Drawing.Point(99, 207);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(0, 20);
            this.lblPatient.TabIndex = 7;
            // 
            // lblMualice
            // 
            this.lblMualice.AutoSize = true;
            this.lblMualice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMualice.Location = new System.Drawing.Point(206, 305);
            this.lblMualice.Name = "lblMualice";
            this.lblMualice.Size = new System.Drawing.Size(0, 20);
            this.lblMualice.TabIndex = 8;
            // 
            // Netice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1018, 410);
            this.Controls.Add(this.lblMualice);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDoc_net);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNetice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Netice";
            this.Tag = "";
            this.Text = "Netice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Netice_FormClosed);
            this.Load += new System.EventHandler(this.Netice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNetice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoc_net;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblMualice;
    }
}