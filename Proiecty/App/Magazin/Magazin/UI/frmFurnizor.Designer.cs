
namespace Magazin.UI
{
    partial class frmFurnizor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFurnizor));
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvFurnizor = new System.Windows.Forms.DataGridView();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtOras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnizor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnizor)).BeginInit();
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
<<<<<<< HEAD
            this.pictureBoxClose.Location = new System.Drawing.Point(1035, 11);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(17, 20);
=======
            this.pictureBoxClose.Location = new System.Drawing.Point(1023, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(32, 32);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 4);
            this.label1.Name = "label1";
<<<<<<< HEAD
            this.label1.Size = new System.Drawing.Size(91, 23);
=======
            this.label1.Size = new System.Drawing.Size(107, 28);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.label1.TabIndex = 0;
            this.label1.Text = "Furnizori";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
<<<<<<< HEAD
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
=======
            this.panel1.BackColor = System.Drawing.Color.Red;
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 39);
            this.panel1.TabIndex = 4;
<<<<<<< HEAD
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
=======
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(16, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(286, 43);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Stergere";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
<<<<<<< HEAD
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
=======
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(16, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(286, 43);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Modificare";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
<<<<<<< HEAD
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
=======
            this.btnAdd.BackColor = System.Drawing.Color.Red;
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(286, 43);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Adaugare";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(342, 68);
            this.lblSearch.Name = "lblSearch";
<<<<<<< HEAD
            this.lblSearch.Size = new System.Drawing.Size(61, 19);
=======
            this.lblSearch.Size = new System.Drawing.Size(71, 22);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.lblSearch.TabIndex = 39;
            this.lblSearch.Text = "Cautare";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(419, 66);
            this.txtSearch.Name = "txtSearch";
<<<<<<< HEAD
            this.txtSearch.Size = new System.Drawing.Size(624, 27);
=======
            this.txtSearch.Size = new System.Drawing.Size(624, 30);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.txtSearch.TabIndex = 38;
            // 
            // dgvFurnizor
            // 
<<<<<<< HEAD
            this.dgvFurnizor.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
=======
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.dgvFurnizor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFurnizor.Location = new System.Drawing.Point(346, 101);
            this.dgvFurnizor.Name = "dgvFurnizor";
            this.dgvFurnizor.RowHeadersWidth = 62;
            this.dgvFurnizor.RowTemplate.Height = 28;
            this.dgvFurnizor.Size = new System.Drawing.Size(697, 286);
            this.dgvFurnizor.TabIndex = 37;
            this.dgvFurnizor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFurnizor_RowHeaderMouseClick);
            // 
            // txtTara
            // 
            this.txtTara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTara.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTara.Location = new System.Drawing.Point(97, 135);
            this.txtTara.Multiline = true;
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(205, 24);
            this.txtTara.TabIndex = 36;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(65, 68);
            this.lblCod.Name = "lblCod";
<<<<<<< HEAD
            this.lblCod.Size = new System.Drawing.Size(22, 19);
=======
            this.lblCod.Size = new System.Drawing.Size(26, 22);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.lblCod.TabIndex = 35;
            this.lblCod.Text = "Id";
            // 
            // txtNume
            // 
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(97, 101);
            this.txtNume.Name = "txtNume";
<<<<<<< HEAD
            this.txtNume.Size = new System.Drawing.Size(205, 27);
=======
            this.txtNume.Size = new System.Drawing.Size(205, 30);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.txtNume.TabIndex = 34;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.Location = new System.Drawing.Point(45, 135);
            this.lblPrenume.Name = "lblPrenume";
<<<<<<< HEAD
            this.lblPrenume.Size = new System.Drawing.Size(37, 19);
=======
            this.lblPrenume.Size = new System.Drawing.Size(46, 22);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.lblPrenume.TabIndex = 33;
            this.lblPrenume.Text = "Tara";
            this.lblPrenume.Click += new System.EventHandler(this.lblPrenume_Click);
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(97, 66);
            this.txtId.Name = "txtId";
<<<<<<< HEAD
            this.txtId.Size = new System.Drawing.Size(205, 27);
=======
            this.txtId.Size = new System.Drawing.Size(205, 30);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.txtId.TabIndex = 32;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(35, 103);
            this.lblNume.Name = "lblNume";
<<<<<<< HEAD
            this.lblNume.Size = new System.Drawing.Size(50, 19);
=======
            this.lblNume.Size = new System.Drawing.Size(56, 22);
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.lblNume.TabIndex = 31;
            this.lblNume.Text = "Nume";
            this.lblNume.Click += new System.EventHandler(this.lblNume_Click);
            // 
            // txtOras
            // 
            this.txtOras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOras.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOras.Location = new System.Drawing.Point(97, 165);
            this.txtOras.Multiline = true;
            this.txtOras.Name = "txtOras";
            this.txtOras.Size = new System.Drawing.Size(205, 24);
            this.txtOras.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 165);
            this.label2.Name = "label2";
<<<<<<< HEAD
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Oras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmFurnizor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
=======
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Oras";
            // 
            // frmFurnizor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.ClientSize = new System.Drawing.Size(1055, 427);
            this.Controls.Add(this.txtOras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvFurnizor);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFurnizor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furnizor";
            this.Load += new System.EventHandler(this.frmFurnizor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnizor)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
=======
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvFurnizor;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtOras;
        private System.Windows.Forms.Label label2;
<<<<<<< HEAD
        private System.Windows.Forms.PictureBox pictureBox1;
=======
>>>>>>> 5d8188a32d497cd10bfd658546fa2789367f2a23
    }
}