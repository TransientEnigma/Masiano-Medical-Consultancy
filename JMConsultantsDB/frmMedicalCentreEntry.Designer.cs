namespace JMConsultantsDB
{
    partial class frmMedicalCentreEntry
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
            System.Windows.Forms.Label jM_MedicalCentreNoLabel;
            System.Windows.Forms.Label jM_AddressLabel;
            System.Windows.Forms.Label jM_PostCodeLabel;
            System.Windows.Forms.Label jM_TelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalCentreEntry));
            this.masianoJanzebConsultantsDataSet = new JMConsultantsDB.MasianoJanzebConsultantsDataSet();
            this.p2430705_tblMedicalCentreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2430705_tblMedicalCentreTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalCentreTableAdapter();
            this.tableAdapterManager = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager();
            this.p2430705_tblMedicalCentreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.p2430705_tblMedicalCentreBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtMedicalCentreNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            jM_MedicalCentreNoLabel = new System.Windows.Forms.Label();
            jM_AddressLabel = new System.Windows.Forms.Label();
            jM_PostCodeLabel = new System.Windows.Forms.Label();
            jM_TelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblMedicalCentreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblMedicalCentreBindingNavigator)).BeginInit();
            this.p2430705_tblMedicalCentreBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jM_MedicalCentreNoLabel
            // 
            jM_MedicalCentreNoLabel.AutoSize = true;
            jM_MedicalCentreNoLabel.Location = new System.Drawing.Point(173, 190);
            jM_MedicalCentreNoLabel.Name = "jM_MedicalCentreNoLabel";
            jM_MedicalCentreNoLabel.Size = new System.Drawing.Size(98, 13);
            jM_MedicalCentreNoLabel.TabIndex = 1;
            jM_MedicalCentreNoLabel.Text = "Medical Centre No:";
            // 
            // jM_AddressLabel
            // 
            jM_AddressLabel.AutoSize = true;
            jM_AddressLabel.Location = new System.Drawing.Point(223, 232);
            jM_AddressLabel.Name = "jM_AddressLabel";
            jM_AddressLabel.Size = new System.Drawing.Size(48, 13);
            jM_AddressLabel.TabIndex = 3;
            jM_AddressLabel.Text = "Address:";
            // 
            // jM_PostCodeLabel
            // 
            jM_PostCodeLabel.AutoSize = true;
            jM_PostCodeLabel.Location = new System.Drawing.Point(212, 274);
            jM_PostCodeLabel.Name = "jM_PostCodeLabel";
            jM_PostCodeLabel.Size = new System.Drawing.Size(59, 13);
            jM_PostCodeLabel.TabIndex = 5;
            jM_PostCodeLabel.Text = "Post Code:";
            // 
            // jM_TelLabel
            // 
            jM_TelLabel.AutoSize = true;
            jM_TelLabel.Location = new System.Drawing.Point(246, 314);
            jM_TelLabel.Name = "jM_TelLabel";
            jM_TelLabel.Size = new System.Drawing.Size(25, 13);
            jM_TelLabel.TabIndex = 7;
            jM_TelLabel.Text = "Tel:";
            // 
            // masianoJanzebConsultantsDataSet
            // 
            this.masianoJanzebConsultantsDataSet.DataSetName = "MasianoJanzebConsultantsDataSet";
            this.masianoJanzebConsultantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p2430705_tblMedicalCentreBindingSource
            // 
            this.p2430705_tblMedicalCentreBindingSource.DataMember = "P2430705_tblMedicalCentre";
            this.p2430705_tblMedicalCentreBindingSource.DataSource = this.masianoJanzebConsultantsDataSet;
            // 
            // p2430705_tblMedicalCentreTableAdapter
            // 
            this.p2430705_tblMedicalCentreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P2430705_tblAppointmentTableAdapter = null;
            this.tableAdapterManager.P2430705_tblConsultantTableAdapter = null;
            this.tableAdapterManager.P2430705_tblGPTableAdapter = null;
            this.tableAdapterManager.P2430705_tblHospitalTableAdapter = null;
            this.tableAdapterManager.P2430705_tblMedicalCentreTableAdapter = this.p2430705_tblMedicalCentreTableAdapter;
            this.tableAdapterManager.P2430705_tblMedicalSchoolTableAdapter = null;
            this.tableAdapterManager.P2430705_tblPatientTableAdapter = null;
            this.tableAdapterManager.P2430705_tblPracticeGPTableAdapter = null;
            this.tableAdapterManager.P2430705_tblSpecialityTableAdapter = null;
            this.tableAdapterManager.P2430705_tblStaffTableAdapter = null;
            this.tableAdapterManager.P2430705_tblTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p2430705_tblMedicalCentreBindingNavigator
            // 
            this.p2430705_tblMedicalCentreBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.p2430705_tblMedicalCentreBindingNavigator.BindingSource = this.p2430705_tblMedicalCentreBindingSource;
            this.p2430705_tblMedicalCentreBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.p2430705_tblMedicalCentreBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.p2430705_tblMedicalCentreBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.p2430705_tblMedicalCentreBindingNavigatorSaveItem});
            this.p2430705_tblMedicalCentreBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.p2430705_tblMedicalCentreBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.p2430705_tblMedicalCentreBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.p2430705_tblMedicalCentreBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.p2430705_tblMedicalCentreBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.p2430705_tblMedicalCentreBindingNavigator.Name = "p2430705_tblMedicalCentreBindingNavigator";
            this.p2430705_tblMedicalCentreBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.p2430705_tblMedicalCentreBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.p2430705_tblMedicalCentreBindingNavigator.TabIndex = 0;
            this.p2430705_tblMedicalCentreBindingNavigator.Text = "bindingNavigator1";
            this.p2430705_tblMedicalCentreBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // p2430705_tblMedicalCentreBindingNavigatorSaveItem
            // 
            this.p2430705_tblMedicalCentreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.p2430705_tblMedicalCentreBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("p2430705_tblMedicalCentreBindingNavigatorSaveItem.Image")));
            this.p2430705_tblMedicalCentreBindingNavigatorSaveItem.Name = "p2430705_tblMedicalCentreBindingNavigatorSaveItem";
            this.p2430705_tblMedicalCentreBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.p2430705_tblMedicalCentreBindingNavigatorSaveItem.Text = "Save Data";
            this.p2430705_tblMedicalCentreBindingNavigatorSaveItem.Click += new System.EventHandler(this.p2430705_tblMedicalCentreBindingNavigatorSaveItem_Click_1);
            // 
            // txtMedicalCentreNo
            // 
            this.txtMedicalCentreNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalCentreBindingSource, "JM_MedicalCentreNo", true));
            this.txtMedicalCentreNo.Location = new System.Drawing.Point(294, 187);
            this.txtMedicalCentreNo.Name = "txtMedicalCentreNo";
            this.txtMedicalCentreNo.Size = new System.Drawing.Size(100, 20);
            this.txtMedicalCentreNo.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalCentreBindingSource, "JM_Address", true));
            this.txtAddress.Location = new System.Drawing.Point(294, 229);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(328, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPostCode
            // 
            this.txtPostCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalCentreBindingSource, "JM_PostCode", true));
            this.txtPostCode.Location = new System.Drawing.Point(294, 271);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(156, 20);
            this.txtPostCode.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalCentreBindingSource, "JM_Tel", true));
            this.txtTel.Location = new System.Drawing.Point(294, 311);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(156, 20);
            this.txtTel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(92, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medical Centre Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(705, 439);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMedicalCentreEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 522);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(jM_TelLabel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(jM_PostCodeLabel);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(jM_AddressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(jM_MedicalCentreNoLabel);
            this.Controls.Add(this.txtMedicalCentreNo);
            this.Controls.Add(this.p2430705_tblMedicalCentreBindingNavigator);
            this.Name = "frmMedicalCentreEntry";
            this.Text = "frmMedicalCentreEntrycs";
            this.Load += new System.EventHandler(this.frmMedicalCentreEntrycs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblMedicalCentreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblMedicalCentreBindingNavigator)).EndInit();
            this.p2430705_tblMedicalCentreBindingNavigator.ResumeLayout(false);
            this.p2430705_tblMedicalCentreBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasianoJanzebConsultantsDataSet masianoJanzebConsultantsDataSet;
        private System.Windows.Forms.BindingSource p2430705_tblMedicalCentreBindingSource;
        private MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalCentreTableAdapter p2430705_tblMedicalCentreTableAdapter;
        private MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator p2430705_tblMedicalCentreBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton p2430705_tblMedicalCentreBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtMedicalCentreNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}