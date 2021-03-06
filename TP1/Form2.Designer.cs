
namespace TP1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnWebCatalog = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pFilter = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpDasar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBeli = new System.Windows.Forms.Button();
            this.lbHarga = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.pbBarang = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flpDasar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(589, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnWebCatalog);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(164, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 94);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.Image = global::TP1.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(403, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 40);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "       L O G O U T";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnWebCatalog
            // 
            this.btnWebCatalog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWebCatalog.FlatAppearance.BorderSize = 2;
            this.btnWebCatalog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnWebCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebCatalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWebCatalog.Image = global::TP1.Properties.Resources.catalogue;
            this.btnWebCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebCatalog.Location = new System.Drawing.Point(203, 29);
            this.btnWebCatalog.Name = "btnWebCatalog";
            this.btnWebCatalog.Size = new System.Drawing.Size(160, 40);
            this.btnWebCatalog.TabIndex = 7;
            this.btnWebCatalog.Text = "       W E B  C A T A L O G";
            this.btnWebCatalog.UseVisualStyleBackColor = true;
            this.btnWebCatalog.Click += new System.EventHandler(this.btnWebCatalog_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.Image = global::TP1.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(72, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(95, 40);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "      H O M E";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(589, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(643, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "1901012";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(643, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dinda Wahyu R.";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pFilter);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(1, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 535);
            this.panel4.TabIndex = 7;
            // 
            // pFilter
            // 
            this.pFilter.Controls.Add(this.btnKembali);
            this.pFilter.Location = new System.Drawing.Point(5, 130);
            this.pFilter.Name = "pFilter";
            this.pFilter.Size = new System.Drawing.Size(150, 134);
            this.pFilter.TabIndex = 12;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKembali.Location = new System.Drawing.Point(16, 37);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(121, 32);
            this.btnKembali.TabIndex = 12;
            this.btnKembali.Text = "K E M B A L I";
            this.btnKembali.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // flpDasar
            // 
            this.flpDasar.AutoScroll = true;
            this.flpDasar.Controls.Add(this.panel2);
            this.flpDasar.Location = new System.Drawing.Point(248, 162);
            this.flpDasar.Name = "flpDasar";
            this.flpDasar.Size = new System.Drawing.Size(632, 302);
            this.flpDasar.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.btnBeli);
            this.panel2.Controls.Add(this.lbHarga);
            this.panel2.Controls.Add(this.lbNama);
            this.panel2.Controls.Add(this.pbBarang);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 194);
            this.panel2.TabIndex = 0;
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(31, 157);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(107, 26);
            this.btnBeli.TabIndex = 7;
            this.btnBeli.Text = "button1";
            this.btnBeli.UseVisualStyleBackColor = true;
            // 
            // lbHarga
            // 
            this.lbHarga.AutoSize = true;
            this.lbHarga.Location = new System.Drawing.Point(28, 136);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(35, 13);
            this.lbHarga.TabIndex = 6;
            this.lbHarga.Text = "label6";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(28, 115);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(35, 13);
            this.lbNama.TabIndex = 5;
            this.lbNama.Text = "label5";
            // 
            // pbBarang
            // 
            this.pbBarang.BackColor = System.Drawing.Color.Gray;
            this.pbBarang.Image = global::TP1.Properties.Resources.television;
            this.pbBarang.Location = new System.Drawing.Point(55, 30);
            this.pbBarang.Name = "pbBarang";
            this.pbBarang.Size = new System.Drawing.Size(64, 64);
            this.pbBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBarang.TabIndex = 4;
            this.pbBarang.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.Location = new System.Drawing.Point(43, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dnie.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 531);
            this.Controls.Add(this.flpDasar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flpDasar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnWebCatalog;
        private System.Windows.Forms.FlowLayoutPanel flpDasar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbBarang;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Label lbHarga;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Panel pFilter;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label5;
    }
}