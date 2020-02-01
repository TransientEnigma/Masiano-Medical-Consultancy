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
    public partial class frmConsultantAppointmentsReport : Form
    {
        public frmConsultantAppointmentsReport()
        {
            InitializeComponent();
        }

        private void UpdateReport(DateTime StartDateInput, DateTime EndDateInput)
        {
            // TODO: This line of code loads data into the 'MasianoJanzebConsultantsDataSet.sproc_ConsultantsAppointmentDates' table. You can move, or remove it, as needed.
            this.sproc_ConsultantsAppointmentDatesTableAdapter.Fill(this.MasianoJanzebConsultantsDataSet.sproc_ConsultantsAppointmentDates, StartDateInput, EndDateInput);

            //Pass a date parameter list to the rptConsultantsAppointmentDates.rdlc specifying the date parameters in rptConsultantsAppointmentDates.rdlc
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JMConsultantsDB.rptConsultantsAppointmentDates.rdlc";
            //List array for report parameters
            List<Microsoft.Reporting.WinForms.ReportParameter> ReportParameterList = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            //add the parameter for chosenStartDate to the list(specifying parameter and value)
            ReportParameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("rptStartDate", Convert.ToString(StartDateInput)));
            //add the parameter for chosenEndDate to the list(specifying parameter and value)
            ReportParameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("rptEndDate", Convert.ToString(EndDateInput)));
            //pass into the rptConsultantsAppointmentDates.rdlc what the DateTime parameter is now
            ReportParameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("rptCurrentDateTime", Convert.ToString(DateTime.Now)));

            this.reportViewer1.LocalReport.SetParameters(ReportParameterList);

            this.reportViewer1.RefreshReport();
        }

        private void frmConsultantAppointmentsReport_Load(object sender, EventArgs e)
        {
            //Declare some variables to store the chosen start and end dates to go into the stored procedure
            DateTime chosenStartDate = Convert.ToDateTime("January 01 1900");
            DateTime chosenEndDate = Convert.ToDateTime("December 31 2020");

            //when the reprot form loads we want it to display last 30 days of appointments
            //Make chosenEndDate todays date
            chosenEndDate = DateTime.Now;
        
            //30 days in TimeSpan parameters are D,H, M, S
            TimeSpan thirtyDays = new System.TimeSpan(30, 0, 0, 0);
            //subtract 30days from chosenEndDate
            chosenStartDate = chosenEndDate.Subtract(thirtyDays);

            //Assign the dates above to the date time pickers
            dtpStartDate.Text = Convert.ToString(chosenStartDate);
            dtpEndDate.Text = Convert.ToString(chosenEndDate);

            this.UpdateReport(chosenStartDate, chosenEndDate);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Declare some variables to store the chosen start and end dates to go into the stored procedure
            DateTime chosenStartDate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime chosenEndDate = Convert.ToDateTime(dtpEndDate.Text);

            //check the date range is valid
            if(chosenStartDate > chosenEndDate)
            {
                MessageBox.Show("The start date cannot be after the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            this.UpdateReport(chosenStartDate, chosenEndDate);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the report
            this.Close();
        }
    }
}
