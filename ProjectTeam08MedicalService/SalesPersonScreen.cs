using MedicalServiceCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam08MedicalService
{
    public partial class SalesPersonScreen : Form
    {
        public SalesPersonScreen()
        {
            InitializeComponent();
            AddOrUpdateForm_Load();


            PatientInquiryScreen enquiry = new PatientInquiryScreen();
            buttonPatientInquiry.Click += (s, e) => AddOrUpdateForm<Inquiry>(dataGridViewInquiry, enquiry, "inquiry");

            SalesReportAddUpdateScreen sale = new SalesReportAddUpdateScreen();
            buttonSalesReport.Click += (s, e) => AddOrUpdateForm<Sale>(dataGridViewInquiry, sale, "sale");

            InitializeDataGridView<Inquiry>(dataGridViewInquiry, "inquiry", "sales");
            InitializeDataGridView<Sale>(dataGridViewSales, "sales", "inquiry");
        }

        private void AddChildForm(Form form)
        {
            var result = form.ShowDialog();
            form.Hide();
        }

        public void AddOrUpdateForm_Load()
        {
            MedicalServiceEntities context = new MedicalServiceEntities();
            dataGridViewInquiry.DataSource = context.Inquiries.ToList();
            dataGridViewSales.DataSource = context.Sales.ToList();
        }

        public void InitializeDataGridView<T>(DataGridView dataGridView, string DbName, params string[] columns) where T : class
        {

            MedicalServiceEntities context = new MedicalServiceEntities();
            //set datagridView to add, delete and update rows
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = true;
            dataGridView.ReadOnly = true;

            if (DbName == "inquiry")
            {
                dataGridView.DataSource = context.Inquiries.ToList();

            }
            if (DbName == "sales")
            {
                dataGridView.DataSource = context.Sales.ToList();

            }

            // hide the navproperties
            foreach (string column in columns)
                dataGridView.Columns[column].Visible = false;
        }

        public void AddOrUpdateForm<T>(DataGridView dataGridView, Form form, string DbName) where T : class
        {
            var result = form.ShowDialog();

            MedicalServiceEntities context = new MedicalServiceEntities();
            if (result == DialogResult.OK)
            {                //MessageBox.Show("perfect");
                if (DbName == "inquiry")
                {
                    dataGridView.DataSource = context.Inquiries.ToList();
                    dataGridViewInquiry.Refresh();

                }
                if (DbName == "sales")
                {
                    dataGridViewSales.DataSource = context.Sales.ToList();
                    dataGridViewSales.Refresh();

                }
            }
            form.Hide();
        }

    }
}
