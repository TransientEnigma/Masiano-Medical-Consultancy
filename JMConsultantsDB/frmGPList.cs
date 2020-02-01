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
    public partial class frmGPList : Form
    {
        public frmGPList()
        {
            InitializeComponent();
        }

        //create a simple class to store and retrieve the GPNo
        //this is private and can only be accessed by variables and procedures within the this class
        //private variable to store the GPNumber       
        private string theGPNumber;

        //sets the value of theGPNumber
        private void setGPNumber(string GPNumber)
        {
            theGPNumber = GPNumber;
        }
        //gets the value of theGPNumber
        public string getGPNumber()
        {
            return theGPNumber;
        }

        //Declare (create) an event variable used to signal each time a GP is selected from the list
        public event EventHandler GPSelectedFromList;

        //this function is capable of sending the signal across forms 
        //(by signalling to parent a GP has been selected)

        // the below method is can be executed in response to the event of a GP being selected from the list
        protected virtual void OnGPSelectedFromList(EventArgs e)
        {
            EventHandler myHandler = GPSelectedFromList;
            if (myHandler != null)
            {
                myHandler(this, e);
                
            }
        }

      
               
        private void frmGPList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masianoJanzebConsultantsDataSet.P2430705_tblGP' table. You can move, or remove it, as needed.
            this.p2430705_tblGPTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.P2430705_tblGP);

            //execute the stored procedure to filter the list with a list of matching GPs
            this.sproc_Filter_by_GPName_GPNumberTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.sproc_Filter_by_GPName_GPNumber, txtGPSearchNo.Text, txtGPSearchName.Text);
            //disable Edit and Delete buttons
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an instance of frmGPDataEntry
            frmGPDataEntry GPEntryForm = new frmGPDataEntry();
            //make the form a child of the mdi parent
            GPEntryForm.MdiParent = this.MdiParent;
            //display the GP Entry form
            GPEntryForm.Show();
            //invoke the AddNewGP method (in frmGPDataEntry)
            GPEntryForm.AddNewGP(); //prepares the form for data entry
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Enable the Edit button when the list is clicked on and item selected
            btnEdit.Enabled = true;
            //Enable the Delete button when he list is clicked on and item selected
            btnDelete.Enabled = true;
            //check to see if a record has been selected
            if (lstGPs.SelectedIndex != -1)
            {
                //get the selected value from list, equal to the primary key
                string selectedGPNumber = Convert.ToString(lstGPs.SelectedValue);
                //call the local setGPNumber method to store the selected GP number
                setGPNumber(selectedGPNumber);
                //call the event handler function to signal to the parent form that a GPNumber has been selected
                // and ready to fetch 
                OnGPSelectedFromList(null);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //declare a variable to store the GP number from the list box
            Int32 GPNo;
            //check to see if a record has been selected
            if (lstGPs.SelectedIndex != -1)
            {

                //get the selected value from the list which should contain the primary key
                GPNo = Convert.ToInt32(lstGPs.SelectedValue);

                //Create an instance of the frmGPDataEntry
                frmGPDataEntry GPEntryForm = new frmGPDataEntry();
                //make the form a child of the mdi parent
                //This line makes the form a child of the mdi parent of the current form. 
                //This means that both forms share the same parent
                GPEntryForm.MdiParent = this.MdiParent;
                //display the GPEntry form
                GPEntryForm.Show();
                //invoke the findGP method (that we created in frmGPDataEntry)
                GPEntryForm.FindGP(GPNo);//Filter form for this GP no
            }
            else
            {
                //if nothing is selected on the list then display a message
                MessageBox.Show("Please select a GP from the list", "GPs List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //declare a variable to store the result returned by the message box
            DialogResult Response;
            //ask the user if they really mean it
            Response = MessageBox.Show("Are you sure you want to delete the GP?", "Delete GP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Response == DialogResult.Yes)
            {
                //declare a variable to store the index of the item on the list
                Int32 Index;
                //get the index from the listbox
                Index = lstGPs.SelectedIndex;
                //delete the record
                masianoJanzebConsultantsDataSet.P2430705_tblGP.Rows[Index].Delete();
                //update the data to the database using the data adapter
                this.p2430705_tblGPTableAdapter.Update(this.masianoJanzebConsultantsDataSet);

            }
        }

        private void frmGPList_Activated(object sender, EventArgs e)
        {
            //load the data from the GP table
            //this.p2430705_tblGPTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.P2430705_tblGP); had to replace with below code to load list

            //execute the stored procedure to filter the list with a list of matching GPs
            this.sproc_Filter_by_GPName_GPNumberTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.sproc_Filter_by_GPName_GPNumber, txtGPSearchNo.Text, txtGPSearchName.Text);
            //disable the edit button
            btnEdit.Enabled = false;
            //disable the delete button
            btnDelete.Enabled = false;
        }

        private void btnGPSearch_Click(object sender, EventArgs e)
        {
            //execute the stored procedure to filter the list with a list of matching GPs
            this.sproc_Filter_by_GPName_GPNumberTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.sproc_Filter_by_GPName_GPNumber, txtGPSearchNo.Text, txtGPSearchName.Text);
            //disable Edit and Delete buttons
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
