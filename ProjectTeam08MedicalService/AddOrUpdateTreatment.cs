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
    public partial class AddOrUpdateTreatment : Form
    {
        public AddOrUpdateTreatment()
        {
            InitializeComponent();
            this.Load += AddOrUpdateTreatment_Load;
            buttonAddTreatment.Click += ButtonAddTreatment_Click;
            buttonUpdateTreatment.Click += ButtonUpdateTreatment_Click;
            listBoxTreatment.SelectedIndexChanged += ListBoxTreatment_SelectedIndexChanged;

        }
        /// <summary>
        /// Get object of department type of selected data from list box and set other values of that record into other data fields 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBoxTreatment.SelectedItem is Treatment treatment))
                return;
            textBoxTreatment.Text = treatment.TreatmentName.ToString();
            textBoxTreatmentPrice.Text = treatment.TreatmentPrice.ToString();

            for (int i = 0; i < listBoxDoctor.Items.Count; i++)
            {
                Doctor doctor = listBoxDoctor.Items[i] as Doctor;
                if (treatment.DoctorID == doctor.DoctorID)
                {
                    listBoxDoctor.SetSelected(i, true);
                }
            }
        }

        private void ButtonUpdateTreatment_Click(object sender, EventArgs e)
        {
            if (!(listBoxTreatment.SelectedItem is Treatment treatment))
            {
                MessageBox.Show("Please select the Treatment to Update!");
                return;
            }

            //Get the selected coursess data
            Doctor doctor = listBoxDoctor.SelectedItem as Doctor;

            treatment.TreatmentPrice = Int32.Parse(textBoxTreatmentPrice.Text); ;
            treatment.TreatmentName = textBoxTreatment.Text;
            treatment.DoctorID = doctor.DoctorID;

            //check that the treatment name and doctor number entries are not null
            if (treatment.EntryIsInValid())
            {
                MessageBox.Show("treatment Name or TreatmentPrice  is missing.");
                return;
            }

            //Check if the entered treatment number is equla to it's  last entered data.
            if (treatment.TreatmentName != treatment.TreatmentName || treatment.DoctorID != treatment.DoctorID)
            {
                if (treatment.TreatmentExists())
                    MessageBox.Show("Treatment: " + treatment.TreatmentName + " " + treatment.DoctorID + " exists. Please enter valid unique Course");
                return;
            }


            //Update the selected course's data
            if (Controller<MedicalServiceEntities, Treatment>.UpdateEntity(treatment) == false)
            {
                MessageBox.Show("Cannot update selected treatmnet to database");
                return;
            }

            this.DialogResult = DialogResult.OK;

            Close(); // this will not dispose the form on hide!
        }

        private void ButtonAddTreatment_Click(object sender, EventArgs e)
        {
            if (listBoxDoctor.SelectedIndex < 0)
            {
                MessageBox.Show("Doctor is not selected");
                return;
            }

            Doctor doctor = listBoxDoctor.SelectedItem as Doctor;

            Treatment treatment = new Treatment()
            {
                TreatmentName = textBoxTreatment.Text,
                TreatmentPrice = Int32.Parse(textBoxTreatmentPrice.Text),
                DoctorID = doctor.DoctorID
            };

            //Check that course number and course name are not blank 
            if (treatment.EntryIsInValid())
            {
                MessageBox.Show("Treatment  or Treatment Name is missing.");
                return;
            }


            //Method to add the new treantment to the database
            if (Controller<MedicalServiceEntities, Treatment>.AddEntity(treatment) == null)
            {
                MessageBox.Show("Cannot add new Treatment to database");
                return;
            }
            //close the form.

            this.DialogResult = DialogResult.OK;

            Close();  // this will not dispose the form on hide!
        }

        /// <summary>
        /// Load form, craete from once and refersh eachtime;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateTreatment_Load(object sender, EventArgs e)
        {
            // bind the data for doctor and treatment listbox.
            listBoxTreatment.DataSource = Controller<MedicalServiceEntities, Treatment>.GetEntitiesWithIncluded("Doctor");
            listBoxDoctor.DataSource = Controller<MedicalServiceEntities, Doctor>.SetBindingList();

            // no course is selected to start
            listBoxTreatment.SelectedIndex = -1;

            // set all textboxes to blank
            textBoxTreatment.ResetText();
            textBoxTreatmentPrice.ResetText();
        }

    }
}
