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
    public partial class frmMedicalCentreEntry : Form
    {
        public frmMedicalCentreEntry()
        {
            InitializeComponent();
        }

        private void p2430705_tblMedicalCentreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p2430705_tblMedicalCentreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masianoJanzebConsultantsDataSet);

        }

        private void p2430705_tblMedicalCentreBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.p2430705_tblMedicalCentreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masianoJanzebConsultantsDataSet);

        }

        private void frmMedicalCentreEntrycs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masianoJanzebConsultantsDataSet.P2430705_tblMedicalCentre' table. You can move, or remove it, as needed.
            this.p2430705_tblMedicalCentreTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.P2430705_tblMedicalCentre);
           
            //This form is only a look up form so no need to enter text in the text boxes
            txtAddress.Enabled = false;
            txtMedicalCentreNo.Enabled = false;
            txtPostCode.Enabled = false;
            txtTel.Enabled = false;
        }
        public void FindMedicalCentre(Int32 MedicalCentreNo)
        {

            //public procedure that shows the details of the MedicalCentre (based on MedicalCentreNo passed to it)
            //Filter the data on tpassed as a parameter
           
           p2430705_tblMedicalCentreBindingSource.Filter= "JM_MedicalCentreNo = " + Convert.ToString(MedicalCentreNo);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
