
namespace Magazin.UI
{
    partial class frmAdresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdresa));
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtOras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStrada = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtIDClient = new System.Windows.Forms.TextBox();
            this.lbltip = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAdresa = new System.Windows.Forms.DataGridView();
            this.txtBloc = new System.Windows.Forms.TextBox();
            this.txtScara = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEtaj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApartament = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1110, 9);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adrese";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 31);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtPrenume
            // 
            this.txtPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.Location = new System.Drawing.Point(98, 125);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.ReadOnly = true;
            this.txtPrenume.Size = new System.Drawing.Size(182, 27);
            this.txtPrenume.TabIndex = 95;
            // 
            // txtNume
            // 
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(98, 96);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.ReadOnly = true;
            this.txtNume.Size = new System.Drawing.Size(182, 27);
            this.txtNume.TabIndex = 94;
            // 
            // txtOras
            // 
            this.txtOras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOras.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOras.Location = new System.Drawing.Point(98, 154);
            this.txtOras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOras.Name = "txtOras";
            this.txtOras.Size = new System.Drawing.Size(182, 27);
            this.txtOras.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 92;
            this.label4.Text = "Oras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "Nume ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 90;
            this.label3.Text = "Prenume";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(26, 520);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(254, 34);
            this.btnDelete.TabIndex = 89;
            this.btnDelete.Text = "Stergere";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(26, 481);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(254, 34);
            this.btnUpdate.TabIndex = 88;
            this.btnUpdate.Text = "Modificare";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(26, 442);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(254, 34);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Text = "Adaugare";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStrada
            // 
            this.txtStrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStrada.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrada.Location = new System.Drawing.Point(98, 182);
            this.txtStrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStrada.Name = "txtStrada";
            this.txtStrada.Size = new System.Drawing.Size(182, 27);
            this.txtStrada.TabIndex = 86;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(12, 40);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(76, 19);
            this.lblCod.TabIndex = 85;
            this.lblCod.Text = "ID Adresa";
            this.lblCod.Click += new System.EventHandler(this.lblCod_Click);
            // 
            // txtIDClient
            // 
            this.txtIDClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDClient.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDClient.Location = new System.Drawing.Point(98, 67);
            this.txtIDClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDClient.Name = "txtIDClient";
            this.txtIDClient.Size = new System.Drawing.Size(182, 27);
            this.txtIDClient.TabIndex = 84;
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltip.Location = new System.Drawing.Point(38, 184);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(51, 19);
            this.lbltip.TabIndex = 83;
            this.lbltip.Text = "Strada";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(98, 38);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(182, 27);
            this.txtId.TabIndex = 82;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(19, 69);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(72, 19);
            this.lblNume.TabIndex = 81;
            this.lblNume.Text = "ID Client";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(289, 42);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 19);
            this.lblSearch.TabIndex = 98;
            this.lblSearch.Text = "Cautare";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(357, 40);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(778, 27);
            this.txtSearch.TabIndex = 97;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvAdresa
            // 
            this.dgvAdresa.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAdresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdresa.Location = new System.Drawing.Point(357, 69);
            this.dgvAdresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdresa.Name = "dgvAdresa";
            this.dgvAdresa.RowHeadersWidth = 62;
            this.dgvAdresa.RowTemplate.Height = 28;
            this.dgvAdresa.Size = new System.Drawing.Size(778, 487);
            this.dgvAdresa.TabIndex = 96;
            this.dgvAdresa.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAdresa_RowHeaderMouseClick);
            // 
            // txtBloc
            // 
            this.txtBloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBloc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloc.Location = new System.Drawing.Point(98, 240);
            this.txtBloc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBloc.Name = "txtBloc";
            this.txtBloc.Size = new System.Drawing.Size(182, 27);
            this.txtBloc.TabIndex = 104;
            // 
            // txtScara
            // 
            this.txtScara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScara.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScara.Location = new System.Drawing.Point(98, 269);
            this.txtScara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScara.Name = "txtScara";
            this.txtScara.Size = new System.Drawing.Size(182, 27);
            this.txtScara.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 102;
            this.label5.Text = "Scara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 101;
            this.label6.Text = "Bloc";
            // 
            // txtEtaj
            // 
            this.txtEtaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEtaj.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtaj.Location = new System.Drawing.Point(98, 298);
            this.txtEtaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEtaj.Name = "txtEtaj";
            this.txtEtaj.Size = new System.Drawing.Size(182, 27);
            this.txtEtaj.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 99;
            this.label7.Text = "Etaj";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtApartament
            // 
            this.txtApartament.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApartament.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartament.Location = new System.Drawing.Point(98, 326);
            this.txtApartament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApartament.Name = "txtApartament";
            this.txtApartament.Size = new System.Drawing.Size(182, 27);
            this.txtApartament.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 105;
            this.label8.Text = "Apartament";
            // 
            // txtNumar
            // 
            this.txtNumar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumar.Location = new System.Drawing.Point(98, 211);
            this.txtNumar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(182, 27);
            this.txtNumar.TabIndex = 108;
            this.txtNumar.TextChanged += new System.EventHandler(this.txtNumar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 107;
            this.label9.Text = "Numar";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // frmAdresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1140, 586);
            this.Controls.Add(this.txtNumar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtApartament);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBloc);
            this.Controls.Add(this.txtScara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEtaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAdresa);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtOras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStrada);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtIDClient);
            this.Controls.Add(this.lbltip);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adresa";
            this.Load += new System.EventHandler(this.frmAdresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtOras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStrada;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtIDClient;
        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAdresa;
        private System.Windows.Forms.TextBox txtBloc;
        private System.Windows.Forms.TextBox txtScara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEtaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApartament;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}