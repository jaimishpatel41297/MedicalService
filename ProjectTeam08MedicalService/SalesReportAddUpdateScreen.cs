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
    public partial class SalesReportAddUpdateScreen : Form
    {
        public SalesReportAddUpdateScreen()
        {
            InitializeComponent();
            AddOrUpdateForm_Load();
            buttonAddSalesReport.Click += (s, e) => AddSales();
            buttonUpdateSalesReport.Click += (s, e) => UpdateSales();

            listBoxSales.SelectedIndex = -1;
            listBoxSales.Click += (s, e) => Display();
        }

        public void AddOrUpdateForm_Load()
        {
            MedicalServiceEntities context = new MedicalServiceEntities();
            listBoxSales.DataSource = context.Sales.ToList();
            textBoxPatientName.ResetText();
        }

        public void AddSales()
        {
            MedicalServiceEntities context = new MedicalServiceEntities();

            Sale sales = listBoxSales.SelectedItem as Sale;
            Sale newSale = new Sale()
            {
                SalesID = Convert.ToInt32(textBoxSalesID.Text),
                PatientEmail = textBoxPatientEmail.Text,
                DoctorID = Convert.ToInt32(textBoxDoctorID.Text),
                TreatmentID = Convert.ToInt32(textBoxTreatmentID.Text),
                PatientsFullName = textBoxPatientName.Text,
                PhoneNumber = Convert.ToInt64(textBoxPhoneNumber.Text),
                DepositRequired = Convert.ToInt64(textBoxDepositRequired.Text),
                TotalRemainingBalance = Convert.ToInt64(textBoxTotalRemaining.Text),
                RemainingBalanceToDoctor = Convert.ToInt64(textBoxRemainingDoctor.Text),
                NetProfit = Convert.ToInt64(textBoxNetProfit.Text),
                DoctorAppointedDate = Convert.ToDateTime(textBoxAppointmentDate.Text)
            };
            context.Sales.Add(newSale);
            context.SaveChanges();

            this.DialogResult = DialogResult.OK;
            Close();
        }
        public void UpdateSales()
        {
            MedicalServiceEntities context = new MedicalServiceEntities();

            Sale sales = listBoxSales.SelectedItem as Sale;
            Sale updatesales = context.Sales.Find(sales.SalesID);

            updatesales.SalesID = Convert.ToInt32(textBoxSalesID.Text);
            updatesales.PatientEmail = textBoxPatientEmail.ToString();
            updatesales.DoctorID = Convert.ToInt32(textBoxDoctorID.Text);
            updatesales.TreatmentID = Convert.ToInt32(textBoxTreatmentID.Text);
            updatesales.PatientsFullName = textBoxPatientName.ToString();
            updatesales.PhoneNumber = Convert.ToInt64(textBoxPhoneNumber.Text);
            updatesales.DepositRequired = Convert.ToInt64(textBoxDepositRequired.Text);
            updatesales.TotalRemainingBalance = Convert.ToInt64(textBoxTotalRemaining.Text);
            updatesales.RemainingBalanceToDoctor = Convert.ToInt64(textBoxRemainingDoctor.Text);
            updatesales.NetProfit = Convert.ToInt64(textBoxNetProfit.Text);
            updatesales.DoctorAppointedDate = Convert.ToDateTime(textBoxAppointmentDate.Text);

            context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public void Display()
        {

            Sale sales = listBoxSales.SelectedItem as Sale;

            textBoxSalesID.Text = sales.SalesID.ToString();
            textBoxPatientEmail.Text = sales.PatientEmail;
            textBoxDoctorID.Text = sales.DoctorID.ToString();
            textBoxTreatmentID.Text = sales.TreatmentID.ToString();
            textBoxPatientName.Text = sales.PatientsFullName;
            textBoxPhoneNumber.Text = sales.PhoneNumber.ToString();
            textBoxDepositRequired.Text = sales.DepositRequired.ToString();
            textBoxTotalRemaining.Text = sales.TotalRemainingBalance.ToString();
            textBoxRemainingDoctor.Text = sales.RemainingBalanceToDoctor.ToString();
            textBoxNetProfit.Text = sales.NetProfit.ToString();
            textBoxAppointmentDate.Text = sales.DoctorAppointedDate.ToString();
        }

    }
}
