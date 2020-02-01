using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMConsultantsDB
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnGPLookup_Click(object sender, EventArgs e)
        {
            //creat an instance of frmGPList
            frmGPList GPLookup = new frmGPList();
            //make the MDI parent of this form the MDI parent of GPLookup
            GPLookup.MdiParent = this.MdiParent;
            //Open the form
            GPLookup.Show();
        }

        private void btnGPDataEntry_Click(object sender, EventArgs e)
        {
            //creat an instance of frmGPDataEntry
            frmGPDataEntry GPDataEntryForm = new frmGPDataEntry();
            //make the MDI parent of this form the MDI parent of GPDataEntryForm
            GPDataEntryForm.MdiParent = this.MdiParent;
            //Open the form
            GPDataEntryForm.Show();
        }

        private void btnMedicalCentreLookup_Click(object sender, EventArgs e)
        {
            //creat an instance of frmMedicalCentreList
            frmMedicalCentreList MedicalCentreLookup = new frmMedicalCentreList();
            //make the MDI parent of this form the MDI parent of MedicalCentreLookup
            MedicalCentreLookup.MdiParent = this.MdiParent;
            //Open the form
            MedicalCentreLookup.Show();
        }

        private void btnMedicalCentreDataEntry_Click(object sender, EventArgs e)
        {
            //creat an instance of frmMedicalCentreList
            frmMedicalCentreEntry MedicalCentreDataEntryForm = new frmMedicalCentreEntry();
            //make the MDI parent of this form the MDI parent of MedicalCentreDataEntryForm
            MedicalCentreDataEntryForm.MdiParent = this.MdiParent;
            //Open the form
            MedicalCentreDataEntryForm.Show();
        }

        private void btnMedicalShoolLookup_Click(object sender, EventArgs e)
        {
            //creat an instance of frmMedicalSchoolList
            frmMedicalSchoolList MedicalSchoolLookup = new frmMedicalSchoolList();
            //make the MDI parent of this form the MDI parent of MedicalSchoolLookup form
            MedicalSchoolLookup.MdiParent = this.MdiParent;
            //Open the form
            MedicalSchoolLookup.Show();
        }

        private void btnMedicalSchoolDataEntry_Click(object sender, EventArgs e)
        {
            //creat an instance of frmMedicalSchoolEntry
            frmMedicalSchoolEntry MedicalSchoolDataEntry = new frmMedicalSchoolEntry();
            //make the MDI parent of this form the MDI parent of MedicalSchoolDataEntry form
            MedicalSchoolDataEntry.MdiParent = this.MdiParent;
            //Open the form
            MedicalSchoolDataEntry.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            //originally thought it would be a good idea but then decided not to use these buttons
            //btnGPDataEntry.Enabled = false;
            //btnGPDataEntry.Visible = false;
            //btnMedicalCentreDataEntry.Enabled = false;
            //btnMedicalCentreDataEntry.Visible = false;
            //btnMedicalSchoolDataEntry.Enabled = false;
            //btnMedicalSchoolDataEntry.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the main menu
            this.Close();
        }
    }
}
