
namespace ProjectTeam08MedicalService
{
    partial class PatientInquiryScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonUpdatePatient = new System.Windows.Forms.Button();
            this.listBoxPatientEmail = new System.Windows.Forms.ListBox();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatientNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInquiryStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSourceOfInquiry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTreatmentId = new System.Windows.Forms.TextBox();
            this.listBoxTreatment = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddPatient.Location = new System.Drawing.Point(405, 403);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(96, 65);
            this.buttonAddPatient.TabIndex = 0;
            this.buttonAddPatient.Text = "ADD NEW PATIENT";
            this.buttonAddPatient.UseVisualStyleBackColor = false;
            // 
            // buttonUpdatePatient
            // 
            this.buttonUpdatePatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdatePatient.Location = new System.Drawing.Point(549, 403);
            this.buttonUpdatePatient.Name = "buttonUpdatePatient";
            this.buttonUpdatePatient.Size = new System.Drawing.Size(92, 65);
            this.buttonUpdatePatient.TabIndex = 1;
            this.buttonUpdatePatient.Text = "UPDATE PATIENT";
            this.buttonUpdatePatient.UseVisualStyleBackColor = false;
            // 
            // listBoxPatientEmail
            // 
            this.listBoxPatientEmail.FormattingEnabled = true;
            this.listBoxPatientEmail.Location = new System.Drawing.Point(96, 25);
            this.listBoxPatientEmail.Name = "listBoxPatientEmail";
            this.listBoxPatientEmail.Size = new System.Drawing.Size(186, 160);
            this.listBoxPatientEmail.TabIndex = 3;
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(417, 198);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(71, 13);
            this.labelPatientName.TabIndex = 4;
            this.labelPatientName.Text = "Patient Name";
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(541, 191);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatientName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Number";
            // 
            // textBoxPatientNumber
            // 
            this.textBoxPatientNumber.Location = new System.Drawing.Point(541, 226);
            this.textBoxPatientNumber.Name = "textBoxPatientNumber";
            this.textBoxPatientNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatientNumber.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inquiry Status";
            // 
            // textBoxInquiryStatus
            // 
            this.textBoxInquiryStatus.Location = new System.Drawing.Point(541, 258);
            this.textBoxInquiryStatus.Name = "textBoxInquiryStatus";
            this.textBoxInquiryStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxInquiryStatus.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Source Of Inquiry";
            // 
            // textBoxSourceOfInquiry
            // 
            this.textBoxSourceOfInquiry.Location = new System.Drawing.Point(541, 294);
            this.textBoxSourceOfInquiry.Name = "textBoxSourceOfInquiry";
            this.textBoxSourceOfInquiry.Size = new System.Drawing.Size(100, 20);
            this.textBoxSourceOfInquiry.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Treatment ID";
            // 
            // textBoxTreatmentId
            // 
            this.textBoxTreatmentId.Location = new System.Drawing.Point(541, 328);
            this.textBoxTreatmentId.Name = "textBoxTreatmentId";
            this.textBoxTreatmentId.Size = new System.Drawing.Size(100, 20);
            this.textBoxTreatmentId.TabIndex = 13;
            // 
            // listBoxTreatment
            // 
            this.listBoxTreatment.FormattingEnabled = true;
            this.listBoxTreatment.Location = new System.Drawing.Point(96, 265);
            this.listBoxTreatment.Name = "listBoxTreatment";
            this.listBoxTreatment.Size = new System.Drawing.Size(186, 160);
            this.listBoxTreatment.TabIndex = 14;
            // 
            // PatientInquiryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 545);
            this.Controls.Add(this.listBoxTreatment);
            this.Controls.Add(this.textBoxTreatmentId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSourceOfInquiry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInquiryStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPatientNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatientName);
            this.Controls.Add(this.labelPatientName);
            this.Controls.Add(this.listBoxPatientEmail);
            this.Controls.Add(this.buttonUpdatePatient);
            this.Controls.Add(this.buttonAddPatient);
            this.Name = "PatientInquiryScreen";
            this.Text = "PatientInquiryScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonUpdatePatient;
        private System.Windows.Forms.ListBox listBoxPatientEmail;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatientNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInquiryStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSourceOfInquiry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTreatmentId;
        private System.Windows.Forms.ListBox listBoxTreatment;
    }
}