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
    public partial class frmMedicalCentreList : Form
    {
        public frmMedicalCentreList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void frmMedicalCentreList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masianoJanzebConsultantsDataSet.P2430705_tblMedicalCentre' table. You can move, or remove it, as needed.
            this.p2430705_tblMedicalCentreTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.P2430705_tblMedicalCentre);
            //we dont need the add edit delete buttons
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare a variable to store the MedicalCentres number from the list box
            Int32 MedicalCentreNo;
            //check to see if a record has been selected
            if (lstMedicalCentres.SelectedIndex != -1)
            {

                //get the selected value from the list which should contain the primary key
                MedicalCentreNo = Convert.ToInt32(lstMedicalCentres.SelectedValue);

                //Create an instance of the frmGPDataEntry
                frmMedicalCentreEntry MedicalCentreEntryForm = new frmMedicalCentreEntry();
                //make the form a child of the mdi parent
                //This line makes the form a child of the mdi parent of the current form. 
                //This means that both forms share the same parent
                MedicalCentreEntryForm.MdiParent = this.MdiParent;
                //display the MedicalCentreEntry form
                MedicalCentreEntryForm.Show();
                //invoke the findMedicalCentre method (that we created in frmMedicalCentreDataEntry)
                MedicalCentreEntryForm.FindMedicalCentre(MedicalCentreNo);//Filter form for this GP no
            }
            else
            {
                //if nothing is selected on the list then display a message
                MessageBox.Show("Please select a GP from the list", "GPs List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
