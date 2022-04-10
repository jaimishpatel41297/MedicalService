using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using MedicalServiceCodeFirstFromDB;


namespace ProjectTeam08MedicalService
{
    public partial class AdminSideFroms : Form
    {
        public AdminSideFroms()
        {
            InitializeComponent();

            this.Text = "Student registration using AddUpdate Forms";

            MedicalServiceEntities context = new MedicalServiceEntities();


            InitializeDataGridView<Doctor>(dataGridViewDoctor, "Treatments", "Sales");
            InitializeDataGridView<Treatment>(dataGridViewTreatment, "Sales", "Inquiries", "Doctor");

            AddOrUpdateDoctor addOrUpdatedoctor = new AddOrUpdateDoctor();
            AddOrUpdateTreatment addOrUpdatetraetment = new AddOrUpdateTreatment();
            ViewSalesReport viewreport = new ViewSalesReport();

            //buttonAddOrUpdateDoctorData.Click += (s, e) => addOrUpdatedoctor.ShowDialog();
            buttonAddOrUpdateDoctorData.Click += (s, e) => AddUpdateForm<Doctor>(dataGridViewDoctor, addOrUpdatedoctor);
            buttonAddOrUpdateTreatmentData.Click += (s, e) => AddUpdateForm<Treatment>(dataGridViewTreatment, addOrUpdatetraetment);
            buttonViewReports.Click += (s, e) =>
            {
                var result = viewreport.ShowDialog();
                viewreport.Hide();
            };
        }

        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);

            gridView.DataSource = Controller<MedicalServiceEntities, T>.SetBindingList();

            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }


        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

        private void AddUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            //Form has closed

            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview

                dataGridView.DataSource = Controller<MedicalServiceEntities, T>.SetBindingList();
            }

            form.Hide();


        }
    }
}
