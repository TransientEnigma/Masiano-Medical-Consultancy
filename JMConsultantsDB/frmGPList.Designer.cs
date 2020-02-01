namespace JMConsultantsDB
{
    partial class frmGPList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGPList));
            this.lstGPs = new System.Windows.Forms.ListBox();
            this.sprocFilterbyGPNameGPNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masianoJanzebConsultantsDataSet = new JMConsultantsDB.MasianoJanzebConsultantsDataSet();
            this.p2430705tblGPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.p2430705_tblGPTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblGPTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGPSearchName = new System.Windows.Forms.TextBox();
            this.txtGPSearchNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGPSearch = new System.Windows.Forms.Button();
            this.sproc_Filter_by_GPName_GPNumberTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.sproc_Filter_by_GPName_GPNumberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sprocFilterbyGPNameGPNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705tblGPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGPs
            // 
            this.lstGPs.DataSource = this.sprocFilterbyGPNameGPNumberBindingSource;
            this.lstGPs.DisplayMember = "JM_Name";
            this.lstGPs.FormattingEnabled = true;
            this.lstGPs.Location = new System.Drawing.Point(105, 117);
            this.lstGPs.Name = "lstGPs";
            this.lstGPs.Size = new System.Drawing.Size(500, 290);
            this.lstGPs.TabIndex = 1;
            this.lstGPs.ValueMember = "JM_GPNo";
            this.lstGPs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sprocFilterbyGPNameGPNumberBindingSource
            // 
            this.sprocFilterbyGPNameGPNumberBindingSource.DataMember = "sproc_Filter_by_GPName_GPNumber";
            this.sprocFilterbyGPNameGPNumberBindingSource.DataSource = this.masianoJanzebConsultantsDataSet;
            // 
            // masianoJanzebConsultantsDataSet
            // 
            this.masianoJanzebConsultantsDataSet.DataSetName = "MasianoJanzebConsultantsDataSet";
            this.masianoJanzebConsultantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p2430705tblGPBindingSource
            // 
            this.p2430705tblGPBindingSource.DataMember = "P2430705_tblGP";
            this.p2430705tblGPBindingSource.DataSource = this.masianoJanzebConsultantsDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(186, 414);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(530, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // p2430705_tblGPTableAdapter
            // 
            this.p2430705_tblGPTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(98, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "General Practitioners Data Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtGPSearchName
            // 
            this.txtGPSearchName.Location = new System.Drawing.Point(99, 55);
            this.txtGPSearchName.Name = "txtGPSearchName";
            this.txtGPSearchName.Size = new System.Drawing.Size(129, 20);
            this.txtGPSearchName.TabIndex = 2;
            // 
            // txtGPSearchNo
            // 
            this.txtGPSearchNo.Location = new System.Drawing.Point(99, 81);
            this.txtGPSearchNo.Name = "txtGPSearchNo";
            this.txtGPSearchNo.Size = new System.Drawing.Size(129, 20);
            this.txtGPSearchNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "GP Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "GP Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(95, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Search GP";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGPSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGPSearchNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGPSearchName);
            this.panel1.Location = new System.Drawing.Point(611, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 147);
            this.panel1.TabIndex = 13;
            // 
            // btnGPSearch
            // 
            this.btnGPSearch.Location = new System.Drawing.Point(153, 107);
            this.btnGPSearch.Name = "btnGPSearch";
            this.btnGPSearch.Size = new System.Drawing.Size(75, 23);
            this.btnGPSearch.TabIndex = 4;
            this.btnGPSearch.Text = "Search";
            this.btnGPSearch.UseVisualStyleBackColor = true;
            this.btnGPSearch.Click += new System.EventHandler(this.btnGPSearch_Click);
            // 
            // sproc_Filter_by_GPName_GPNumberTableAdapter
            // 
            this.sproc_Filter_by_GPName_GPNumberTableAdapter.ClearBeforeFill = true;
            // 
            // frmGPList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstGPs);
            this.Controls.Add(this.panel1);
            this.Name = "frmGPList";
            this.Text = "frmGPList";
            this.Activated += new System.EventHandler(this.frmGPList_Activated);
            this.Load += new System.EventHandler(this.frmGPList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sprocFilterbyGPNameGPNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705tblGPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGPs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private MasianoJanzebConsultantsDataSet masianoJanzebConsultantsDataSet;
        private System.Windows.Forms.BindingSource p2430705tblGPBindingSource;
        private MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblGPTableAdapter p2430705_tblGPTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGPSearchName;
        private System.Windows.Forms.TextBox txtGPSearchNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGPSearch;
        private System.Windows.Forms.BindingSource sprocFilterbyGPNameGPNumberBindingSource;
        private MasianoJanzebConsultantsDataSetTableAdapters.sproc_Filter_by_GPName_GPNumberTableAdapter sproc_Filter_by_GPName_GPNumberTableAdapter;
    }
}