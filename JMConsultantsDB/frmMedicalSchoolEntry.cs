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
    public partial class frmMedicalSchoolEntry : Form
    {
        public frmMedicalSchoolEntry()
        {
            InitializeComponent();
        }

        private void p2430705_tblMedicalSchoolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p2430705_tblMedicalSchoolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masianoJanzebConsultantsDataSet);

        }

        private void frmMedicalSchoolEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masianoJanzebConsultantsDataSet.P2430705_tblMedicalSchool' table. You can move, or remove it, as needed.
            this.p2430705_tblMedicalSchoolTableAdapter.Fill(this.masianoJanzebConsultantsDataSet.P2430705_tblMedicalSchool);
            //we don't need this button
            btnSave.Enabled = false;
            btnSave.Visible = false;


        }

        public void AddNewSchool()
        {
            //This line of code will set the form so a new box can be added
            this.p2430705_tblMedicalSchoolBindingSource.AddNew();
            

        }

        public void FindSchool(string SchoolNo)
        {
            //Filter the data using the SchoolNo(primary key)
            this.p2430705_tblMedicalSchoolBindingSource.Filter = "JM_MedicalSchoolCode = " + "'"+SchoolNo+"'";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Stops the editing of the form
            this.p2430705_tblMedicalSchoolBindingSource.EndEdit();

            //Updates the database
            this.tableAdapterManager.UpdateAll(this.masianoJanzebConsultantsDataSet);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
