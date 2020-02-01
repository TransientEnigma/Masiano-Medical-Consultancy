namespace JMConsultantsDB
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGPLookup = new System.Windows.Forms.Button();
            this.btnMedicalCentreLookup = new System.Windows.Forms.Button();
            this.btnMedicalShoolLookup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(289, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // btnGPLookup
            // 
            this.btnGPLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGPLookup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGPLookup.Location = new System.Drawing.Point(445, 148);
            this.btnGPLookup.Name = "btnGPLookup";
            this.btnGPLookup.Size = new System.Drawing.Size(236, 36);
            this.btnGPLookup.TabIndex = 1;
            this.btnGPLookup.Text = "GP Data Management";
            this.btnGPLookup.UseVisualStyleBackColor = true;
            this.btnGPLookup.Click += new System.EventHandler(this.btnGPLookup_Click);
            // 
            // btnMedicalCentreLookup
            // 
            this.btnMedicalCentreLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalCentreLookup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMedicalCentreLookup.Location = new System.Drawing.Point(445, 206);
            this.btnMedicalCentreLookup.Name = "btnMedicalCentreLookup";
            this.btnMedicalCentreLookup.Size = new System.Drawing.Size(236, 36);
            this.btnMedicalCentreLookup.TabIndex = 2;
            this.btnMedicalCentreLookup.Text = "Medical Centre Lookup";
            this.btnMedicalCentreLookup.UseVisualStyleBackColor = true;
            this.btnMedicalCentreLookup.Click += new System.EventHandler(this.btnMedicalCentreLookup_Click);
            // 
            // btnMedicalShoolLookup
            // 
            this.btnMedicalShoolLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalShoolLookup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMedicalShoolLookup.Location = new System.Drawing.Point(445, 265);
            this.btnMedicalShoolLookup.Name = "btnMedicalShoolLookup";
            this.btnMedicalShoolLookup.Size = new System.Drawing.Size(236, 36);
            this.btnMedicalShoolLookup.TabIndex = 3;
            this.btnMedicalShoolLookup.Text = "Medical School Lookup";
            this.btnMedicalShoolLookup.UseVisualStyleBackColor = true;
            this.btnMedicalShoolLookup.Click += new System.EventHandler(this.btnMedicalShoolLookup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(592, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(810, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMedicalShoolLookup);
            this.Controls.Add(this.btnMedicalCentreLookup);
            this.Controls.Add(this.btnGPLookup);
            this.Controls.Add(this.label1);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGPLookup;
        private System.Windows.Forms.Button btnMedicalCentreLookup;
        private System.Windows.Forms.Button btnMedicalShoolLookup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}