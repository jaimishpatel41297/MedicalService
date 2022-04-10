namespace ProjectTeam08MedicalService
{
    partial class AdminSideFroms
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
            this.buttonViewReports = new System.Windows.Forms.Button();
            this.buttonBachUpSalesData = new System.Windows.Forms.Button();
            this.buttonAddOrUpdateDoctorData = new System.Windows.Forms.Button();
            this.buttonAddOrUpdateTreatmentData = new System.Windows.Forms.Button();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTreatment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonViewReports
            // 
            this.buttonViewReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonViewReports.Location = new System.Drawing.Point(325, 644);
            this.buttonViewReports.Name = "buttonViewReports";
            this.buttonViewReports.Size = new System.Drawing.Size(160, 80);
            this.buttonViewReports.TabIndex = 0;
            this.buttonViewReports.Text = "View Reports";
            this.buttonViewReports.UseVisualStyleBackColor = false;
            // 
            // buttonBachUpSalesData
            // 
            this.buttonBachUpSalesData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBachUpSalesData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBachUpSalesData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBachUpSalesData.Location = new System.Drawing.Point(620, 644);
            this.buttonBachUpSalesData.Name = "buttonBachUpSalesData";
            this.buttonBachUpSalesData.Size = new System.Drawing.Size(160, 80);
            this.buttonBachUpSalesData.TabIndex = 1;
            this.buttonBachUpSalesData.Text = "Back-Up Sales Data";
            this.buttonBachUpSalesData.UseVisualStyleBackColor = false;
            // 
            // buttonAddOrUpdateDoctorData
            // 
            this.buttonAddOrUpdateDoctorData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddOrUpdateDoctorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdateDoctorData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddOrUpdateDoctorData.Location = new System.Drawing.Point(1060, 159);
            this.buttonAddOrUpdateDoctorData.Name = "buttonAddOrUpdateDoctorData";
            this.buttonAddOrUpdateDoctorData.Size = new System.Drawing.Size(160, 80);
            this.buttonAddOrUpdateDoctorData.TabIndex = 2;
            this.buttonAddOrUpdateDoctorData.Text = "Add Or Update Doctor Data";
            this.buttonAddOrUpdateDoctorData.UseVisualStyleBackColor = false;
            // 
            // buttonAddOrUpdateTreatmentData
            // 
            this.buttonAddOrUpdateTreatmentData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddOrUpdateTreatmentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdateTreatmentData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddOrUpdateTreatmentData.Location = new System.Drawing.Point(1060, 426);
            this.buttonAddOrUpdateTreatmentData.Name = "buttonAddOrUpdateTreatmentData";
            this.buttonAddOrUpdateTreatmentData.Size = new System.Drawing.Size(160, 80);
            this.buttonAddOrUpdateTreatmentData.TabIndex = 3;
            this.buttonAddOrUpdateTreatmentData.Text = "Add Or Update Treatment Data";
            this.buttonAddOrUpdateTreatmentData.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(101, 58);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.RowHeadersWidth = 51;
            this.dataGridViewDoctor.RowTemplate.Height = 24;
            this.dataGridViewDoctor.Size = new System.Drawing.Size(932, 266);
            this.dataGridViewDoctor.TabIndex = 4;
            // 
            // dataGridViewTreatment
            // 
            this.dataGridViewTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreatment.Location = new System.Drawing.Point(101, 354);
            this.dataGridViewTreatment.Name = "dataGridViewTreatment";
            this.dataGridViewTreatment.RowHeadersWidth = 51;
            this.dataGridViewTreatment.RowTemplate.Height = 24;
            this.dataGridViewTreatment.Size = new System.Drawing.Size(932, 258);
            this.dataGridViewTreatment.TabIndex = 5;
            // 
            // AdminSideFroms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.dataGridViewTreatment);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.buttonAddOrUpdateTreatmentData);
            this.Controls.Add(this.buttonAddOrUpdateDoctorData);
            this.Controls.Add(this.buttonBachUpSalesData);
            this.Controls.Add(this.buttonViewReports);
            this.Name = "AdminSideFroms";
            this.Text = "AdminSideFroms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewReports;
        private System.Windows.Forms.Button buttonBachUpSalesData;
        private System.Windows.Forms.Button buttonAddOrUpdateDoctorData;
        private System.Windows.Forms.Button buttonAddOrUpdateTreatmentData;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.DataGridView dataGridViewTreatment;
    }
}