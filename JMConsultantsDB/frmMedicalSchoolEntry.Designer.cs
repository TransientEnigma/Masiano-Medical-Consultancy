namespace JMConsultantsDB
{
    partial class frmMedicalSchoolEntry
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
            System.Windows.Forms.Label jM_MedicalSchoolCodeLabel;
            System.Windows.Forms.Label jM_NameLabel;
            System.Windows.Forms.Label jM_UniversityLabel;
            System.Windows.Forms.Label jM_EstablishedLabel;
            System.Windows.Forms.Label jM_AwardLabel;
            System.Windows.Forms.Label jM_CommentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalSchoolEntry));
            this.masianoJanzebConsultantsDataSet = new JMConsultantsDB.MasianoJanzebConsultantsDataSet();
            this.p2430705_tblMedicalSchoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2430705_tblMedicalSchoolTableAdapter = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalSchoolTableAdapter();
            this.tableAdapterManager = new JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager();
            this.p2430705_tblMedicalSchoolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.jM_MedicalSchoolCodeTextBox = new System.Windows.Forms.TextBox();
            this.jM_NameTextBox = new System.Windows.Forms.TextBox();
            this.jM_UniversityTextBox = new System.Windows.Forms.TextBox();
            this.jM_EstablishedTextBox = new System.Windows.Forms.TextBox();
            this.jM_AwardTextBox = new System.Windows.Forms.TextBox();
            this.jM_CommentsTextBox = new System.Windows.Forms.TextBox();
            jM_MedicalSchoolCodeLabel = new System.Windows.Forms.Label();
            jM_NameLabel = new System.Windows.Forms.Label();
            jM_UniversityLabel = new System.Windows.Forms.Label();
            jM_EstablishedLabel = new System.Windows.Forms.Label();
            jM_AwardLabel = new System.Windows.Forms.Label();
            jM_CommentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblMedicalSchoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblMedicalSchoolBindingNavigator)).BeginInit();
            this.p2430705_tblMedicalSchoolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jM_MedicalSchoolCodeLabel
            // 
            jM_MedicalSchoolCodeLabel.AutoSize = true;
            jM_MedicalSchoolCodeLabel.Location = new System.Drawing.Point(145, 189);
            jM_MedicalSchoolCodeLabel.Name = "jM_MedicalSchoolCodeLabel";
            jM_MedicalSchoolCodeLabel.Size = new System.Drawing.Size(128, 13);
            jM_MedicalSchoolCodeLabel.TabIndex = 16;
            jM_MedicalSchoolCodeLabel.Text = "JM Medical School Code:";
            // 
            // jM_NameLabel
            // 
            jM_NameLabel.AutoSize = true;
            jM_NameLabel.Location = new System.Drawing.Point(145, 232);
            jM_NameLabel.Name = "jM_NameLabel";
            jM_NameLabel.Size = new System.Drawing.Size(55, 13);
            jM_NameLabel.TabIndex = 17;
            jM_NameLabel.Text = "JM Name:";
            // 
            // jM_UniversityLabel
            // 
            jM_UniversityLabel.AutoSize = true;
            jM_UniversityLabel.Location = new System.Drawing.Point(145, 277);
            jM_UniversityLabel.Name = "jM_UniversityLabel";
            jM_UniversityLabel.Size = new System.Drawing.Size(73, 13);
            jM_UniversityLabel.TabIndex = 18;
            jM_UniversityLabel.Text = "JM University:";
            // 
            // jM_EstablishedLabel
            // 
            jM_EstablishedLabel.AutoSize = true;
            jM_EstablishedLabel.Location = new System.Drawing.Point(145, 320);
            jM_EstablishedLabel.Name = "jM_EstablishedLabel";
            jM_EstablishedLabel.Size = new System.Drawing.Size(81, 13);
            jM_EstablishedLabel.TabIndex = 19;
            jM_EstablishedLabel.Text = "JM Established:";
            // 
            // jM_AwardLabel
            // 
            jM_AwardLabel.AutoSize = true;
            jM_AwardLabel.Location = new System.Drawing.Point(300, 189);
            jM_AwardLabel.Name = "jM_AwardLabel";
            jM_AwardLabel.Size = new System.Drawing.Size(57, 13);
            jM_AwardLabel.TabIndex = 21;
            jM_AwardLabel.Text = "JM Award:";
            // 
            // jM_CommentsLabel
            // 
            jM_CommentsLabel.AutoSize = true;
            jM_CommentsLabel.Location = new System.Drawing.Point(66, 395);
            jM_CommentsLabel.Name = "jM_CommentsLabel";
            jM_CommentsLabel.Size = new System.Drawing.Size(76, 13);
            jM_CommentsLabel.TabIndex = 22;
            jM_CommentsLabel.Text = "JM Comments:";
            // 
            // masianoJanzebConsultantsDataSet
            // 
            this.masianoJanzebConsultantsDataSet.DataSetName = "MasianoJanzebConsultantsDataSet";
            this.masianoJanzebConsultantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p2430705_tblMedicalSchoolBindingSource
            // 
            this.p2430705_tblMedicalSchoolBindingSource.DataMember = "P2430705_tblMedicalSchool";
            this.p2430705_tblMedicalSchoolBindingSource.DataSource = this.masianoJanzebConsultantsDataSet;
            // 
            // p2430705_tblMedicalSchoolTableAdapter
            // 
            this.p2430705_tblMedicalSchoolTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P2430705_tblAppointmentTableAdapter = null;
            this.tableAdapterManager.P2430705_tblConsultantTableAdapter = null;
            this.tableAdapterManager.P2430705_tblGPTableAdapter = null;
            this.tableAdapterManager.P2430705_tblHospitalTableAdapter = null;
            this.tableAdapterManager.P2430705_tblMedicalCentreTableAdapter = null;
            this.tableAdapterManager.P2430705_tblMedicalSchoolTableAdapter = this.p2430705_tblMedicalSchoolTableAdapter;
            this.tableAdapterManager.P2430705_tblPatientTableAdapter = null;
            this.tableAdapterManager.P2430705_tblPracticeGPTableAdapter = null;
            this.tableAdapterManager.P2430705_tblSpecialityTableAdapter = null;
            this.tableAdapterManager.P2430705_tblStaffTableAdapter = null;
            this.tableAdapterManager.P2430705_tblTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JMConsultantsDB.MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p2430705_tblMedicalSchoolBindingNavigator
            // 
            this.p2430705_tblMedicalSchoolBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.p2430705_tblMedicalSchoolBindingNavigator.BindingSource = this.p2430705_tblMedicalSchoolBindingSource;
            this.p2430705_tblMedicalSchoolBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.p2430705_tblMedicalSchoolBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.p2430705_tblMedicalSchoolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem});
            this.p2430705_tblMedicalSchoolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.p2430705_tblMedicalSchoolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.p2430705_tblMedicalSchoolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.p2430705_tblMedicalSchoolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.p2430705_tblMedicalSchoolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.p2430705_tblMedicalSchoolBindingNavigator.Name = "p2430705_tblMedicalSchoolBindingNavigator";
            this.p2430705_tblMedicalSchoolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.p2430705_tblMedicalSchoolBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.p2430705_tblMedicalSchoolBindingNavigator.TabIndex = 0;
            this.p2430705_tblMedicalSchoolBindingNavigator.Text = "bindingNavigator1";
            this.p2430705_tblMedicalSchoolBindingNavigator.Visible = false;
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
            // p2430705_tblMedicalSchoolBindingNavigatorSaveItem
            // 
            this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("p2430705_tblMedicalSchoolBindingNavigatorSaveItem.Image")));
            this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem.Name = "p2430705_tblMedicalSchoolBindingNavigatorSaveItem";
            this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem.Text = "Save Data";
            this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem.Click += new System.EventHandler(this.p2430705_tblMedicalSchoolBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(212, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Medical School Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(584, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(665, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // jM_MedicalSchoolCodeTextBox
            // 
            this.jM_MedicalSchoolCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalSchoolBindingSource, "JM_MedicalSchoolCode", true));
            this.jM_MedicalSchoolCodeTextBox.Location = new System.Drawing.Point(148, 205);
            this.jM_MedicalSchoolCodeTextBox.Name = "jM_MedicalSchoolCodeTextBox";
            this.jM_MedicalSchoolCodeTextBox.Size = new System.Drawing.Size(125, 20);
            this.jM_MedicalSchoolCodeTextBox.TabIndex = 1;
            // 
            // jM_NameTextBox
            // 
            this.jM_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalSchoolBindingSource, "JM_Name", true));
            this.jM_NameTextBox.Location = new System.Drawing.Point(148, 248);
            this.jM_NameTextBox.Name = "jM_NameTextBox";
            this.jM_NameTextBox.Size = new System.Drawing.Size(209, 20);
            this.jM_NameTextBox.TabIndex = 3;
            // 
            // jM_UniversityTextBox
            // 
            this.jM_UniversityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalSchoolBindingSource, "JM_University", true));
            this.jM_UniversityTextBox.Location = new System.Drawing.Point(148, 293);
            this.jM_UniversityTextBox.Name = "jM_UniversityTextBox";
            this.jM_UniversityTextBox.Size = new System.Drawing.Size(209, 20);
            this.jM_UniversityTextBox.TabIndex = 4;
            // 
            // jM_EstablishedTextBox
            // 
            this.jM_EstablishedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalSchoolBindingSource, "JM_Established", true));
            this.jM_EstablishedTextBox.Location = new System.Drawing.Point(148, 336);
            this.jM_EstablishedTextBox.Name = "jM_EstablishedTextBox";
            this.jM_EstablishedTextBox.Size = new System.Drawing.Size(209, 20);
            this.jM_EstablishedTextBox.TabIndex = 5;
            // 
            // jM_AwardTextBox
            // 
            this.jM_AwardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalSchoolBindingSource, "JM_Award", true));
            this.jM_AwardTextBox.Location = new System.Drawing.Point(279, 205);
            this.jM_AwardTextBox.Name = "jM_AwardTextBox";
            this.jM_AwardTextBox.Size = new System.Drawing.Size(78, 20);
            this.jM_AwardTextBox.TabIndex = 2;
            // 
            // jM_CommentsTextBox
            // 
            this.jM_CommentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2430705_tblMedicalSchoolBindingSource, "JM_Comments", true));
            this.jM_CommentsTextBox.Location = new System.Drawing.Point(148, 392);
            this.jM_CommentsTextBox.Name = "jM_CommentsTextBox";
            this.jM_CommentsTextBox.Size = new System.Drawing.Size(515, 20);
            this.jM_CommentsTextBox.TabIndex = 6;
            // 
            // frmMedicalSchoolEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(jM_CommentsLabel);
            this.Controls.Add(this.jM_CommentsTextBox);
            this.Controls.Add(jM_AwardLabel);
            this.Controls.Add(this.jM_AwardTextBox);
            this.Controls.Add(jM_EstablishedLabel);
            this.Controls.Add(this.jM_EstablishedTextBox);
            this.Controls.Add(jM_UniversityLabel);
            this.Controls.Add(this.jM_UniversityTextBox);
            this.Controls.Add(jM_NameLabel);
            this.Controls.Add(this.jM_NameTextBox);
            this.Controls.Add(jM_MedicalSchoolCodeLabel);
            this.Controls.Add(this.jM_MedicalSchoolCodeTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2430705_tblMedicalSchoolBindingNavigator);
            this.Name = "frmMedicalSchoolEntry";
            this.Text = "frmMedicalSchoolEntry";
            this.Load += new System.EventHandler(this.frmMedicalSchoolEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masianoJanzebConsultantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblMedicalSchoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2430705_tblMedicalSchoolBindingNavigator)).EndInit();
            this.p2430705_tblMedicalSchoolBindingNavigator.ResumeLayout(false);
            this.p2430705_tblMedicalSchoolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasianoJanzebConsultantsDataSet masianoJanzebConsultantsDataSet;
        private System.Windows.Forms.BindingSource p2430705_tblMedicalSchoolBindingSource;
        private MasianoJanzebConsultantsDataSetTableAdapters.P2430705_tblMedicalSchoolTableAdapter p2430705_tblMedicalSchoolTableAdapter;
        private MasianoJanzebConsultantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator p2430705_tblMedicalSchoolBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton p2430705_tblMedicalSchoolBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox jM_MedicalSchoolCodeTextBox;
        private System.Windows.Forms.TextBox jM_NameTextBox;
        private System.Windows.Forms.TextBox jM_UniversityTextBox;
        private System.Windows.Forms.TextBox jM_EstablishedTextBox;
        private System.Windows.Forms.TextBox jM_AwardTextBox;
        private System.Windows.Forms.TextBox jM_CommentsTextBox;
    }
}