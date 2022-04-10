using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalServiceCodeFirstFromDB;

namespace ProjectTeam08MedicalService
{
    public partial class ViewSalesReport : Form
    {
        public ViewSalesReport()
        {
            InitializeComponent();

            // Filling the datagrid view with all Sales Data.
            MedicalServiceEntities context = new MedicalServiceEntities();
            dataGridViewAdminSalesReport.DataSource = context.Sales.ToList();
            dataGridViewAdminInquiryReport.DataSource = context.Inquiries.ToList();

            calculateTotalNetProfit();
            calculateTotalNumberOfSales();
            popularTreatment();
            popularDoctor();

            numberOfActivePatients();
            numberOfInactivePatients();
            numberOfTreatedPatients();
            mostPopularSourceOfInquiry();
        }

        private void calculateTotalNetProfit()
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewAdminSalesReport.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewAdminSalesReport.Rows[i].Cells[9].Value);
            }
            labelNetProfitResult.Text = sum.ToString();
        }

        //calculating total number of sales
        private void calculateTotalNumberOfSales()
        {
            labelNumberOfSalesResult.Text = dataGridViewAdminSalesReport.Rows.Count.ToString();
        }
        // finding the most popular treatment
        private void popularTreatment()
        {

        }

        // finding the most popular treatment
        private void popularDoctor()
        {

        }

        //number of Active Patients
        private void numberOfActivePatients()
        {
            int xCount = dataGridViewAdminInquiryReport.Rows
              .Cast<DataGridViewRow>()
              .Count(row => row.Cells[3].Value.ToString() == "Active");

            labelActivePatientsResult.Text = xCount.ToString();
        }

        //number of Inactive Patients
        private void numberOfInactivePatients()
        {
            int xCount = dataGridViewAdminInquiryReport.Rows
              .Cast<DataGridViewRow>()
              .Count(row => row.Cells[3].Value.ToString() == "Inactive");

            labelInactivePatientsResult.Text = xCount.ToString();
        }

        //number of Treated Patients
        private void numberOfTreatedPatients()
        {
            int xCount = dataGridViewAdminInquiryReport.Rows
              .Cast<DataGridViewRow>()
              .Count(row => row.Cells[3].Value.ToString() == "Treated");

            labelTreatedPatientsResults.Text = xCount.ToString();
        }

        // Finding out and printing most popular source of Inquiry
        private void mostPopularSourceOfInquiry()
        {

        }
    }
}
