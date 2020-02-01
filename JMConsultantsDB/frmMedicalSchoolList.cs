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
    public partial class frmMedicalSchoolList : Form
    {
        public frmMedicalSchoolList()
        {
            InitializeComponent();
        }

        
        //create a simple class to store and retrieve the MedicalSchoolNo
        //this is private and can only be accessed by variables and procedures within the this class
        //private variable to store the MedicalSchool Number       
        private string theMedicalSchoolNumber;

        //sets the value of theMedicalSchoolNumber
        private void setMedicalSchoolNumber(string MedicalSchoolNumber)
        {
            theMedicalSchoolNumber = MedicalSchoolNumber;
        }
        //gets the value of theMedicalSchoolNumber
        public string getMedicalSchoolNumber()
        {
            return theMedicalSchoolNumber;
        }

        //Declare (create) an event variable used to signal each time a MedicalSchool is selected from the list
        public event EventHandler MedicalSchoolSelectedFromList;

        //this function is capable of sending the signal across forms 
        //(by signalling to parent a MedicalSchool has been selected)

        // the below method is can be executed in response to the event of a GP being selected from the list
        protected virtual void OnMedicalSchoolSelectedFromList(EventArgs e)
        {
            EventHandler myHandler = MedicalSchoolSelectedFromList;
            if (myHandler != null)
            {
                myHandler(this, e);

            }
        }


        private void frmMedicalSchoolList_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'masianoJanzebConsultantsDataSet.P2430705_tblMedicalSchool' table. You can move, or remove it, as needed.
            this.p2430705_tblMedicalSchoolTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.P2430705_tblMedicalSchool);
            //we dont need the add edit delete buttons
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMedicalSchoolEntry MedicalSchoolEntryForm = new frmMedicalSchoolEntry();
            //make the form parent (MDI property) the same as the current forms parent (MDI property)
            MedicalSchoolEntryForm.MdiParent = this.MdiParent;
            //Open the MedicalSchoolEntryForm
            MedicalSchoolEntryForm.Show();
            //set the BoxForm up for adding a new box.
            MedicalSchoolEntryForm.AddNewSchool();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void lstMedicalSchools_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable the Edit button when the list is clicked on and  item selected
            btnEdit.Enabled = true;
            //Enable the Delete button when he list is clicked on and item selected
            btnDelete.Enabled = true;

            //check to see if a record has been selected
            if (lstMedicalSchools.SelectedIndex != -1)
            {
                //get the selected value from list, equal to the primary key
                string selectedGPNumber = Convert.ToString(lstMedicalSchools.SelectedValue);
                //call the local setMedicalSchoolNumber method to store the selected MedicalSchool number
                setMedicalSchoolNumber(selectedGPNumber);
                //call the event handler function to signal to the parent form that a MedicalSchoolNumber has been selected
                // and ready to fetch 
                OnMedicalSchoolSelectedFromList(null);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMedicalSchoolList_Activated(object sender, EventArgs e)
        {
            //fills dataset with data from tblBox
            this.p2430705_tblMedicalSchoolTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.P2430705_tblMedicalSchool);
            //disable Edit and Delete buttons
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //declare a variable to store the result of the message box
            DialogResult Response;
            //ask the user if they really wan to delete it
            Response = MessageBox.Show("Are you sure you want to delete the School", "Delete School", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if the user clicks yes
            if (Response == DialogResult.Yes)
            {
                //declare a variable to store the index of the item of the list
                Int32 Index;
                //get the index from the listbox
                Index = lstMedicalSchools.SelectedIndex;
                //delete the record from the dataset
                masianoJanzebConsultantsDataSet.P2430705_tblMedicalSchool.Rows[Index].Delete();
                //update table with the data from the dataset
                this.p2430705_tblMedicalSchoolTableAdapter.Update(this.masianoJanzebConsultantsDataSet);
                //update the form to show the changes using the Activated event handler
                this.frmMedicalSchoolList_Activated(null, null);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            //declare an integer variable to store the selected (PK) value of the selected school to edit
            string SchoolNo;
            //if something has been selected in the list
            if (lstMedicalSchools.SelectedIndex != -1)
            {

                //get the SelectedValue (primary key) and store it in SchoolNo
                SchoolNo = Convert.ToString(lstMedicalSchools.SelectedValue);
                //ceate an instance of the Medical School Entry form
                frmMedicalSchoolEntry MedicalSchoolEntryForm = new frmMedicalSchoolEntry();
                //make the form parent (MDI property) the same as the current forms parent (MDI property)
                MedicalSchoolEntryForm.MdiParent = this.MdiParent;
                //Open the MedicalSchoolEntryForm
                MedicalSchoolEntryForm.Show();
                //invoke the method to find and display the selected box in the BoxEntryForm
                MedicalSchoolEntryForm.FindSchool(SchoolNo);
            }
        }
    }
}
