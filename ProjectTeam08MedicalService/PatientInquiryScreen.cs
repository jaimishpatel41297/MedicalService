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
    public partial class PatientInquiryScreen : Form
    {
        public PatientInquiryScreen()
        {
            InitializeComponent();
            AddOrUpdateForm_Load();
            buttonAddPatient.Click += (s, e) => AddPatient();
            buttonUpdatePatient.Click += (s, e) => UpdatePatient();

            listBoxPatientEmail.SelectedIndex = -1;
            listBoxPatientEmail.Click += (s, e) => Display();
        }

        public void AddOrUpdateForm_Load()
        {
            MedicalServiceEntities context = new MedicalServiceEntities();
            listBoxPatientEmail.DataSource = context.Inquiries.ToList();
            listBoxTreatment.DataSource = context.Treatments.ToList();
            textBoxPatientName.ResetText();
        }

        public void AddPatient()
        {
            MedicalServiceEntities context = new MedicalServiceEntities();

            Treatment treatment = listBoxTreatment.SelectedItem as Treatment;
            Inquiry newInquiry = new Inquiry()
            {
                PatientFullName = textBoxPatientName.Text,
                SourceOfInquiry = textBoxSourceOfInquiry.Text,
                InquiryStatus = textBoxInquiryStatus.Text,
                //PhoneNumber = textBoxPatientNumber.Text,
                TreatmentID = treatment.TreatmentID
            };
            context.Inquiries.Add(newInquiry);
            context.SaveChanges();

            this.DialogResult = DialogResult.OK;
            Close();
        }

        public void UpdatePatient()
        {
            MedicalServiceEntities context = new MedicalServiceEntities();

            Inquiry inquiry = listBoxPatientEmail.SelectedItem as Inquiry;
            ///
            Inquiry updateinquiry = context.Inquiries.Find(inquiry.PatientEmail);

            updateinquiry.PatientFullName = textBoxPatientName.Text;
            updateinquiry.InquiryStatus = textBoxInquiryStatus.Text;
           // updateinquiry.PhoneNumber = textBoxPatientNumber.Text;
            updateinquiry.SourceOfInquiry = textBoxSourceOfInquiry.Text;
            context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            Close();
        }
        public void Display()
        {

            Inquiry inquirys = listBoxPatientEmail.SelectedItem as Inquiry;

            textBoxPatientName.Text = inquirys.PatientFullName;
            textBoxInquiryStatus.Text= inquirys.InquiryStatus;
            textBoxPatientNumber.Text = inquirys.PhoneNumber + "";
            textBoxSourceOfInquiry.Text = inquirys.SourceOfInquiry;
            textBoxTreatmentId.Text = inquirys.TreatmentID + "";
        }

       
    }
}
