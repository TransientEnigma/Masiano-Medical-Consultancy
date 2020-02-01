namespace JMConsultantsDB
{
    partial class frmMedicalSchoolList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalSchoolList));
            this.lstMedicalSchools = new System.Windows.Forms.ListBox();
            this.p2430705tblMedicalSchoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masianoJanzebConsultantsDataSet = new JMConsultantsDB.MasianoJanzebConsultantsDataSet();
            this.p2430705_tblMedicalSchoolTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalSchoolTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705tblMedicalSchoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMedicalSchools
            // 
            this.lstMedicalSchools.DataSource = this.p2430705tblMedicalSchoolBindingSource;
            this.lstMedicalSchools.DisplayMember = "JM_Name";
            this.lstMedicalSchools.FormattingEnabled = true;
            this.lstMedicalSchools.Location = new System.Drawing.Point(112, 152);
            this.lstMedicalSchools.Name = "lstMedicalSchools";
            this.lstMedicalSchools.Size = new System.Drawing.Size(547, 264);
            this.lstMedicalSchools.TabIndex = 0;
            this.lstMedicalSchools.ValueMember = "JM_MedicalSchoolCode";
            this.lstMedicalSchools.SelectedIndexChanged += new System.EventHandler(this.lstMedicalSchools_SelectedIndexChanged);
            // 
            // p2430705tblMedicalSchoolBindingSource
            // 
            this.p2430705tblMedicalSchoolBindingSource.DataMember = "P2430705_tblMedicalSchool";
            this.p2430705tblMedicalSchoolBindingSource.DataSource = this.masianoJanzebConsultantsDataSet;
            // 
            // masianoJanzebConsultantsDataSet
            // 
            this.masianoJanzebConsultantsDataSet.DataSetName = "MasianoJanzebConsultantsDataSet";
            this.masianoJanzebConsultantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p2430705_tblMedicalSchoolTableAdapter
            // 
            this.p2430705_tblMedicalSchoolTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(112, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(193, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(274, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(584, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(105, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medical School Lookup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(584, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(503, 422);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(75, 23);
            this.btnViewDetails.TabIndex = 4;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // frmMedicalSchoolList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstMedicalSchools);
            this.Name = "frmMedicalSchoolList";
            this.Text = "Medical School List";
            this.Activated += new System.EventHandler(this.frmMedicalSchoolList_Activated);
            this.Load += new System.EventHandler(this.frmMedicalSchoolList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p2430705tblMedicalSchoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMedicalSchools;
        private MasianoJanzebConsultantsDataSet masianoJanzebConsultantsDataSet;
        private System.Windows.Forms.BindingSource p2430705tblMedicalSchoolBindingSource;
        private MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalSchoolTableAdapter p2430705_tblMedicalSchoolTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewDetails;
    }
}