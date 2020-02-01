namespace JMConsultantsDB
{
    partial class frmGPDataEntry
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
            System.Windows.Forms.Label jM_GPNoLabel;
            System.Windows.Forms.Label jM_NameLabel;
            System.Windows.Forms.Label jM_MedicalSchoolCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGPDataEntry));
            this.masianoJanzebConsultantsDataSet = new JMConsultantsDB.MasianoJanzebConsultantsDataSet();
            this.p2430705_tblGPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2430705_tblGPTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblGPTableAdapter();
            this.tableAdapterManager = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager();
            this.p2430705_tblPracticeGPTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblPracticeGPTableAdapter();
            this.p2430705_tblGPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.p2430705_tblGPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtGPNo = new System.Windows.Forms.TextBox();
            this.txtGPName = new System.Windows.Forms.TextBox();
            this.txtMedicalSchoolCode = new System.Windows.Forms.TextBox();
            this.p2430705_tblPracticeGPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAward = new System.Windows.Forms.TextBox();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.lblAward = new System.Windows.Forms.Label();
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.lblMedSchoolName = new System.Windows.Forms.Label();
            this.txtMedSchoolName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelectfromMedList = new System.Windows.Forms.Button();
            this.p2430705_tblPracticeGPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.p2430705tblMedicalCentreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2430705_tblMedicalCentreTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalCentreTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalDays = new System.Windows.Forms.Label();
            jM_GPNoLabel = new System.Windows.Forms.Label();
            jM_NameLabel = new System.Windows.Forms.Label();
            jM_MedicalSchoolCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblGPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblGPBindingNavigator)).BeginInit();
            this.p2430705_tblGPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblPracticeGPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblPracticeGPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705tblMedicalCentreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jM_GPNoLabel
            // 
            jM_GPNoLabel.AutoSize = true;
            jM_GPNoLabel.Location = new System.Drawing.Point(22, 11);
            jM_GPNoLabel.Name = "jM_GPNoLabel";
            jM_GPNoLabel.Size = new System.Drawing.Size(42, 13);
            jM_GPNoLabel.TabIndex = 1;
            jM_GPNoLabel.Text = "GP No:";
            // 
            // jM_NameLabel
            // 
            jM_NameLabel.AutoSize = true;
            jM_NameLabel.Location = new System.Drawing.Point(23, 50);
            jM_NameLabel.Name = "jM_NameLabel";
            jM_NameLabel.Size = new System.Drawing.Size(38, 13);
            jM_NameLabel.TabIndex = 3;
            jM_NameLabel.Text = "Name:";
            // 
            // jM_MedicalSchoolCodeLabel
            // 
            jM_MedicalSchoolCodeLabel.AutoSize = true;
            jM_MedicalSchoolCodeLabel.Location = new System.Drawing.Point(24, 11);
            jM_MedicalSchoolCodeLabel.Name = "jM_MedicalSchoolCodeLabel";
            jM_MedicalSchoolCodeLabel.Size = new System.Drawing.Size(111, 13);
            jM_MedicalSchoolCodeLabel.TabIndex = 5;
            jM_MedicalSchoolCodeLabel.Text = "Medical School Code:";
            // 
            // masianoJanzebConsultantsDataSet
            // 
            this.masianoJanzebConsultantsDataSet.DataSetName = "MasianoJanzebConsultantsDataSet";
            this.masianoJanzebConsultantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p2430705_tblGPBindingSource
            // 
            this.p2430705_tblGPBindingSource.DataMember = "P2430705_tblGP";
            this.p2430705_tblGPBindingSource.DataSource = this.masianoJanzebConsultantsDataSet;
            // 
            // p2430705_tblGPTableAdapter
            // 
            this.p2430705_tblGPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P2430705_tblAppointmentTableAdapter = null;
            this.tableAdapterManager.P2430705_tblConsultantTableAdapter = null;
            this.tableAdapterManager.P2430705_tblGPTableAdapter = this.p2430705_tblGPTableAdapter;
            this.tableAdapterManager.P2430705_tblHospitalTableAdapter = null;
            this.tableAdapterManager.P2430705_tblMedicalCentreTableAdapter = null;
            this.tableAdapterManager.P2430705_tblMedicalSchoolTableAdapter = null;
            this.tableAdapterManager.P2430705_tblPatientTableAdapter = null;
            this.tableAdapterManager.P2430705_tblPracticeGPTableAdapter = this.p2430705_tblPracticeGPTableAdapter;
            this.tableAdapterManager.P2430705_tblSpecialityTableAdapter = null;
            this.tableAdapterManager.P2430705_tblStaffTableAdapter = null;
            this.tableAdapterManager.P2430705_tblTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p2430705_tblPracticeGPTableAdapter
            // 
            this.p2430705_tblPracticeGPTableAdapter.ClearBeforeFill = true;
            // 
            // p2430705_tblGPBindingNavigator
            // 
            this.p2430705_tblGPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.p2430705_tblGPBindingNavigator.BindingSource = this.p2430705_tblGPBindingSource;
            this.p2430705_tblGPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.p2430705_tblGPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.p2430705_tblGPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.p2430705_tblGPBindingNavigatorSaveItem});
            this.p2430705_tblGPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.p2430705_tblGPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.p2430705_tblGPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.p2430705_tblGPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.p2430705_tblGPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.p2430705_tblGPBindingNavigator.Name = "p2430705_tblGPBindingNavigator";
            this.p2430705_tblGPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.p2430705_tblGPBindingNavigator.Size = new System.Drawing.Size(913, 25);
            this.p2430705_tblGPBindingNavigator.TabIndex = 0;
            this.p2430705_tblGPBindingNavigator.Text = "bindingNavigator1";
            this.p2430705_tblGPBindingNavigator.Visible = false;
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
            // p2430705_tblGPBindingNavigatorSaveItem
            // 
            this.p2430705_tblGPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.p2430705_tblGPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("p2430705_tblGPBindingNavigatorSaveItem.Image")));
            this.p2430705_tblGPBindingNavigatorSaveItem.Name = "p2430705_tblGPBindingNavigatorSaveItem";
            this.p2430705_tblGPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.p2430705_tblGPBindingNavigatorSaveItem.Text = "Save Data";
            this.p2430705_tblGPBindingNavigatorSaveItem.Click += new System.EventHandler(this.p2430705_tblGPBindingNavigatorSaveItem_Click_1);
            // 
            // txtGPNo
            // 
            this.txtGPNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblGPBindingSource, "JM_GPNo", true));
            this.txtGPNo.Location = new System.Drawing.Point(22, 27);
            this.txtGPNo.Name = "txtGPNo";
            this.txtGPNo.Size = new System.Drawing.Size(126, 20);
            this.txtGPNo.TabIndex = 1;
            this.txtGPNo.Text = "                                                       ";
            this.txtGPNo.TextChanged += new System.EventHandler(this.txtGPNo_TextChanged);
            // 
            // txtGPName
            // 
            this.txtGPName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblGPBindingSource, "JM_Name", true));
            this.txtGPName.Location = new System.Drawing.Point(24, 66);
            this.txtGPName.Name = "txtGPName";
            this.txtGPName.Size = new System.Drawing.Size(233, 20);
            this.txtGPName.TabIndex = 2;
            // 
            // txtMedicalSchoolCode
            // 
            this.txtMedicalSchoolCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblGPBindingSource, "JM_MedicalSchoolCode", true));
            this.txtMedicalSchoolCode.Location = new System.Drawing.Point(65, 296);
            this.txtMedicalSchoolCode.Name = "txtMedicalSchoolCode";
            this.txtMedicalSchoolCode.Size = new System.Drawing.Size(127, 20);
            this.txtMedicalSchoolCode.TabIndex = 3;
            this.txtMedicalSchoolCode.TextChanged += new System.EventHandler(this.jM_MedicalSchoolCodeTextBox_TextChanged);
            // 
            // p2430705_tblPracticeGPBindingSource
            // 
            this.p2430705_tblPracticeGPBindingSource.DataMember = "FK_P2430705_tblPracticeGP_tblGP";
            this.p2430705_tblPracticeGPBindingSource.DataSource = this.p2430705_tblGPBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(74, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Genral Practitioner Data Entry";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(798, 512);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(879, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(754, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtAward
            // 
            this.txtAward.Location = new System.Drawing.Point(68, 408);
            this.txtAward.Name = "txtAward";
            this.txtAward.Size = new System.Drawing.Size(232, 20);
            this.txtAward.TabIndex = 11;
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Location = new System.Drawing.Point(64, 355);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(56, 13);
            this.lblUniversity.TabIndex = 17;
            this.lblUniversity.Text = "University:";
            // 
            // lblAward
            // 
            this.lblAward.AutoSize = true;
            this.lblAward.Location = new System.Drawing.Point(65, 392);
            this.lblAward.Name = "lblAward";
            this.lblAward.Size = new System.Drawing.Size(40, 13);
            this.lblAward.TabIndex = 18;
            this.lblAward.Text = "Award:";
            // 
            // txtUniversity
            // 
            this.txtUniversity.Location = new System.Drawing.Point(67, 369);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(233, 20);
            this.txtUniversity.TabIndex = 10;
            // 
            // lblMedSchoolName
            // 
            this.lblMedSchoolName.AutoSize = true;
            this.lblMedSchoolName.Location = new System.Drawing.Point(64, 319);
            this.lblMedSchoolName.Name = "lblMedSchoolName";
            this.lblMedSchoolName.Size = new System.Drawing.Size(114, 13);
            this.lblMedSchoolName.TabIndex = 16;
            this.lblMedSchoolName.Text = "Medical School Name:";
            // 
            // txtMedSchoolName
            // 
            this.txtMedSchoolName.Location = new System.Drawing.Point(65, 332);
            this.txtMedSchoolName.Name = "txtMedSchoolName";
            this.txtMedSchoolName.Size = new System.Drawing.Size(235, 20);
            this.txtMedSchoolName.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(jM_GPNoLabel);
            this.panel1.Controls.Add(this.txtGPNo);
            this.panel1.Controls.Add(this.txtGPName);
            this.panel1.Controls.Add(jM_NameLabel);
            this.panel1.Location = new System.Drawing.Point(40, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 99);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSelectfromMedList);
            this.panel2.Controls.Add(jM_MedicalSchoolCodeLabel);
            this.panel2.Location = new System.Drawing.Point(40, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 181);
            this.panel2.TabIndex = 20;
            // 
            // btnSelectfromMedList
            // 
            this.btnSelectfromMedList.Location = new System.Drawing.Point(158, 23);
            this.btnSelectfromMedList.Name = "btnSelectfromMedList";
            this.btnSelectfromMedList.Size = new System.Drawing.Size(101, 23);
            this.btnSelectfromMedList.TabIndex = 4;
            this.btnSelectfromMedList.Text = "Select from list";
            this.btnSelectfromMedList.UseVisualStyleBackColor = true;
            this.btnSelectfromMedList.Click += new System.EventHandler(this.btnSelectfromMedList_Click);
            // 
            // p2430705_tblPracticeGPDataGridView
            // 
            this.p2430705_tblPracticeGPDataGridView.AutoGenerateColumns = false;
            this.p2430705_tblPracticeGPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p2430705_tblPracticeGPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.p2430705_tblPracticeGPDataGridView.DataSource = this.p2430705_tblPracticeGPBindingSource;
            this.p2430705_tblPracticeGPDataGridView.Location = new System.Drawing.Point(368, 175);
            this.p2430705_tblPracticeGPDataGridView.Name = "p2430705_tblPracticeGPDataGridView";
            this.p2430705_tblPracticeGPDataGridView.Size = new System.Drawing.Size(583, 272);
            this.p2430705_tblPracticeGPDataGridView.TabIndex = 5;
            this.p2430705_tblPracticeGPDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.p2430705_tblPracticeGPDataGridView_CellClick);
            this.p2430705_tblPracticeGPDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.p2430705_tblPracticeGPDataGridView_CellContentClick);
            this.p2430705_tblPracticeGPDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.p2430705_tblPracticeGPDataGridView_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "JM_PracticeGPNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Practice GP No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "JM_GPNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "GP No.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "JM_MedicalCentreNo";
            this.dataGridViewTextBoxColumn3.DataSource = this.p2430705tblMedicalCentreBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "JM_Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Medical Centre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "JM_MedicalCentreNo";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // p2430705tblMedicalCentreBindingSource
            // 
            this.p2430705tblMedicalCentreBindingSource.DataMember = "P2430705_tblMedicalCentre";
            this.p2430705tblMedicalCentreBindingSource.DataSource = this.masianoJanzebConsultantsDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JM_DaysPerWeek";
            this.dataGridViewTextBoxColumn4.HeaderText = "Days Per Week";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // p2430705_tblMedicalCentreTableAdapter
            // 
            this.p2430705_tblMedicalCentreTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(815, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Days";
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.AutoSize = true;
            this.lblTotalDays.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalDays.Location = new System.Drawing.Point(879, 458);
            this.lblTotalDays.MaximumSize = new System.Drawing.Size(50, 20);
            this.lblTotalDays.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(50, 20);
            this.lblTotalDays.TabIndex = 22;
            this.lblTotalDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalDays.Click += new System.EventHandler(this.lblTotalDays_Click);
            this.lblTotalDays.MouseHover += new System.EventHandler(this.lblTotalDays_MouseHover);
            // 
            // frmGPDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1023, 569);
            this.Controls.Add(this.lblTotalDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAward);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.lblMedSchoolName);
            this.Controls.Add(this.txtAward);
            this.Controls.Add(this.txtUniversity);
            this.Controls.Add(this.txtMedSchoolName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2430705_tblPracticeGPDataGridView);
            this.Controls.Add(this.txtMedicalSchoolCode);
            this.Controls.Add(this.p2430705_tblGPBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmGPDataEntry";
            this.Text = "General Practitioner Data Entry";
            this.Load += new System.EventHandler(this.frmGPDataEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblGPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblGPBindingNavigator)).EndInit();
            this.p2430705_tblGPBindingNavigator.ResumeLayout(false);
            this.p2430705_tblGPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblPracticeGPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblPracticeGPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705tblMedicalCentreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasianoJanzebConsultantsDataSet masianoJanzebConsultantsDataSet;
        private System.Windows.Forms.BindingSource p2430705_tblGPBindingSource;
        private MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblGPTableAdapter p2430705_tblGPTableAdapter;
        private MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator p2430705_tblGPBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton p2430705_tblGPBindingNavigatorSaveItem;
        private MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblPracticeGPTableAdapter p2430705_tblPracticeGPTableAdapter;
        private System.Windows.Forms.TextBox txtGPNo;
        private System.Windows.Forms.TextBox txtGPName;
        private System.Windows.Forms.TextBox txtMedicalSchoolCode;
        private System.Windows.Forms.BindingSource p2430705_tblPracticeGPBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAward;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblAward;
        private System.Windows.Forms.TextBox txtUniversity;
        private System.Windows.Forms.Label lblMedSchoolName;
        private System.Windows.Forms.TextBox txtMedSchoolName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView p2430705_tblPracticeGPDataGridView;
        private System.Windows.Forms.Button btnSelectfromMedList;
        private System.Windows.Forms.BindingSource p2430705tblMedicalCentreBindingSource;
        private MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalCentreTableAdapter p2430705_tblMedicalCentreTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblTotalDays;
    }
}

