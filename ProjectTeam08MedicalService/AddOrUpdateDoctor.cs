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
using EFControllerUtilities;
using MedicalServiceCodeFirstFromDB;
using MedicalServiceValidation;

namespace ProjectTeam08MedicalService
{
    public partial class AddOrUpdateDoctor : Form
    {
        public AddOrUpdateDoctor()
        {

            InitializeComponent();
            this.Load += AddOrUpdateDoctor_Load;
            buttonAddDoctor.Click += ButtonAddDoctor_Click; ;
            buttonUpdateDoctor.Click += ButtonUpdateDoctor_Click;

            // register event handler for when a doctor is selected
            listBoxDoctor.SelectedIndexChanged += (s, e) => GetDoctors();
        }

        /// <summary>
        /// The form is initially created, but loaded each time it is shown.
        /// Reload data each time the form loaded.
        /// This is the handler for the Load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateDoctor_Load(object sender, EventArgs e)
        {
            listBoxDoctor.DataSource = Controller<MedicalServiceEntities, Doctor>.SetBindingList();

            //set selected index of the departments listbox to -1 to ensure nothing is selected and Reset all textboxes controls to blank
            listBoxDoctor.SelectedIndex = -1;
            textBoxDoctorName.ResetText();
            textBoxDoctorPhone.ResetText();
        }

        /// <summary>
        /// Set data to field when particular doctor is selected from listbox
        /// </summary>
        private void GetDoctors()
        {
            if (!(listBoxDoctor.SelectedItem is Doctor doctors))
                return;
            textBoxDoctorName.Text = doctors.DoctorName;
            textBoxDoctorPhone.Text = doctors.DoctorPhone.ToString();
        }

        /// <summary>
        /// The form is initially created, but loaded each time it is shown.
        /// Reload data each time the form loaded.
        /// This is the handler for the Load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateDoctor_Click(object sender, EventArgs e)
        {
            if (!(listBoxDoctor.SelectedItem is Doctor doctors))
            {
                MessageBox.Show("Doctor to be updated must be selected");
                return;
            }

            doctors.DoctorName = textBoxDoctorName.Text;
            doctors.DoctorPhone = Int64.Parse(textBoxDoctorPhone.Text);

            //if (doctors.DoctorNAmeExists())
            //{
            //    MessageBox.Show("Doctor Name: " + doctors.DoctorName + " already exists. Please enter anothe name");
            //    return;
            //}

            // validation to check entered doctor data.
            if (doctors.EntryIsInValid())
            {
                MessageBox.Show("Entered data for doctor is missing Docot name");
                return;
            }

            //Update the selected doctor data
            if (Controller<MedicalServiceEntities, Doctor>.UpdateEntity(doctors) == false)
            {

                MessageBox.Show("Cannot update selected doctor to database");
                return;
            }

            this.DialogResult = DialogResult.OK;

            Close(); // this will not dispose the form on hide!
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                DoctorName = textBoxDoctorName.Text,
                DoctorPhone = int.Parse(textBoxDoctorPhone.Text)
            };

            // validation to check entered doctor data.
            if (doctor.EntryIsInValid())
            {
                MessageBox.Show("Entered data for doctor is missing Docot name");
                return;
            }
            //Use the Controller  to add the new doctor into the DB
            if (Controller<MedicalServiceEntities, Doctor>.AddEntity(doctor) == null)
            {
                MessageBox.Show("Cannot add new doctor to database");
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
