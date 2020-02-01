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
    public partial class JMConsultants : Form
    {
        private int childFormNumber = 0;

        public JMConsultants()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void generalPractitionersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instance of frmGPList
            frmGPList GPListForm = new frmGPList();
            //make its parent of this parent
            GPListForm.MdiParent = this;
            //display the form
            GPListForm.Show();
        }

        private void medicalSchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instance of frmMedicalSchoolList
            frmMedicalSchoolList MedicalSchoolForm = new frmMedicalSchoolList();
            //make its parent of this parent
            MedicalSchoolForm.MdiParent = this;
            //display the form
            MedicalSchoolForm.Show();
        }

        private void gPDataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gPDataEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Instance of frmGPDataEntry
            frmGPDataEntry GPDataEntryForm = new frmGPDataEntry();
            //make its parent of this parent
            GPDataEntryForm.MdiParent = this;
            //display the form
            GPDataEntryForm.Show();
        }

        private void medicalCentresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instance of frmMedicalCentreEntry
            frmMedicalCentreList MedicalCentreListForm = new frmMedicalCentreList();
            //make its parent of this parent
            MedicalCentreListForm.MdiParent = this;
            //display the form
            MedicalCentreListForm.Show();
        }

        private void consultantsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an instance of the report form
            frmConsultantAppointmentsReport ConsultantsAppointmentsReportForm = new frmConsultantAppointmentsReport();
            //make its parent of this parent
            ConsultantsAppointmentsReportForm.MdiParent = this;
            //display the form
            ConsultantsAppointmentsReportForm.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an instance of the MainMenu form
            frmMainMenu MainMenuForm = new frmMainMenu();
            //make its parent of this parent
            MainMenuForm.MdiParent = this;
            //display the form
            MainMenuForm.Show();
        }
    }
}
