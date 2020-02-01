namespace JMConsultantsDB
{
    partial class frmMedicalCentreList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalCentreList));
            this.lstMedicalCentres = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.masianoJanzebConsultantsDataSet = new JMConsultantsDB.MasianoJanzebConsultantsDataSet();
            this.p2430705tblMedicalCentreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2430705_tblMedicalCentreTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalCentreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705tblMedicalCentreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMedicalCentres
            // 
            this.lstMedicalCentres.DataSource = this.p2430705tblMedicalCentreBindingSource;
            this.lstMedicalCentres.DisplayMember = "JM_Address";
            this.lstMedicalCentres.FormattingEnabled = true;
            this.lstMedicalCentres.Location = new System.Drawing.Point(130, 161);
            this.lstMedicalCentres.Name = "lstMedicalCentres";
            this.lstMedicalCentres.Size = new System.Drawing.Size(552, 290);
            this.lstMedicalCentres.TabIndex = 0;
            this.lstMedicalCentres.ValueMember = "JM_MedicalCentreNo";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(217, 457);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(299, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(600, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(128, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medical Centres Lookup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(633, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "View Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // masianoJanzebConsultantsDataSet
            // 
            this.masianoJanzebConsultantsDataSet.DataSetName = "MasianoJanzebConsultantsDataSet";
            this.masianoJanzebConsultantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p2430705tblMedicalCentreBindingSource
            // 
            this.p2430705tblMedicalCentreBindingSource.DataMember = "P2430705_tblMedicalCentre";
            this.p2430705tblMedicalCentreBindingSource.DataSource = this.masianoJanzebConsultantsDataSet;
            // 
            // p2430705_tblMedicalCentreTableAdapter
            // 
            this.p2430705_tblMedicalCentreTableAdapter.ClearBeforeFill = true;
            // 
            // frmMedicalCentreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(839, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstMedicalCentres);
            this.Name = "frmMedicalCentreList";
            this.Text = "frmMedicalCentreList";
            this.Load += new System.EventHandler(this.frmMedicalCentreList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705tblMedicalCentreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMedicalCentres;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private MasianoJanzebConsultantsDataSet masianoJanzebConsultantsDataSet;
        private System.Windows.Forms.BindingSource p2430705tblMedicalCentreBindingSource;
        private MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalCentreTableAdapter p2430705_tblMedicalCentreTableAdapter;
    }
}