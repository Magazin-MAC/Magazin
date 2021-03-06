
namespace Magazin.UI
{
    partial class frmAutoComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoComp));
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProducator = new System.Windows.Forms.TextBox();
            this.txtCodMotor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lbltip = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAutoComp = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1026, 9);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(21, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automobile compatibile";
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
            this.panel1.Size = new System.Drawing.Size(1051, 31);
            this.panel1.TabIndex = 5;
            // 
            // txtProducator
            // 
            this.txtProducator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducator.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducator.Location = new System.Drawing.Point(106, 177);
            this.txtProducator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.Size = new System.Drawing.Size(182, 27);
            this.txtProducator.TabIndex = 80;
            // 
            // txtCodMotor
            // 
            this.txtCodMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodMotor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodMotor.Location = new System.Drawing.Point(106, 148);
            this.txtCodMotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodMotor.Name = "txtCodMotor";
            this.txtCodMotor.Size = new System.Drawing.Size(182, 27);
            this.txtCodMotor.TabIndex = 79;
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(106, 205);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(182, 27);
            this.txtModel.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 77;
            this.label4.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 76;
            this.label2.Text = "Cod Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Producator";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(106, 423);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 34);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Stergere";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(106, 384);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 34);
            this.btnUpdate.TabIndex = 73;
            this.btnUpdate.Text = "Modificare";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(106, 345);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 34);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Adaugare";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAn
            // 
            this.txtAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAn.Location = new System.Drawing.Point(106, 234);
            this.txtAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(182, 27);
            this.txtAn.TabIndex = 71;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(78, 92);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(22, 19);
            this.lblCod.TabIndex = 70;
            this.lblCod.Text = "Id";
            // 
            // txtCodProd
            // 
            this.txtCodProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd.Location = new System.Drawing.Point(106, 119);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(182, 27);
            this.txtCodProd.TabIndex = 69;
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltip.Location = new System.Drawing.Point(71, 236);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(28, 19);
            this.lbltip.TabIndex = 68;
            this.lbltip.Text = "An";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(106, 90);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(182, 27);
            this.txtId.TabIndex = 67;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(16, 121);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(87, 19);
            this.lblNume.TabIndex = 66;
            this.lblNume.Text = "Cod produs";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(291, 42);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 19);
            this.lblSearch.TabIndex = 83;
            this.lblSearch.Text = "Cautare";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(359, 41);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(681, 27);
            this.txtSearch.TabIndex = 82;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvAutoComp
            // 
            this.dgvAutoComp.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAutoComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoComp.Location = new System.Drawing.Point(359, 70);
            this.dgvAutoComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAutoComp.Name = "dgvAutoComp";
            this.dgvAutoComp.RowHeadersWidth = 62;
            this.dgvAutoComp.RowTemplate.Height = 28;
            this.dgvAutoComp.Size = new System.Drawing.Size(681, 388);
            this.dgvAutoComp.TabIndex = 81;
            this.dgvAutoComp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAutoComp_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAutoComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1051, 482);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAutoComp);
            this.Controls.Add(this.txtProducator);
            this.Controls.Add(this.txtCodMotor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.lbltip);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAutoComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAutoComp";
            this.Load += new System.EventHandler(this.frmAutoComp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProducator;
        private System.Windows.Forms.TextBox txtCodMotor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAutoComp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}