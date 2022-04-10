
namespace ProjectTeam08MedicalService
{
    partial class SalesPersonScreen
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
            this.buttonPatientInquiry = new System.Windows.Forms.Button();
            this.buttonSalesReport = new System.Windows.Forms.Button();
            this.dataGridViewInquiry = new System.Windows.Forms.DataGridView();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInquiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPatientInquiry
            // 
            this.buttonPatientInquiry.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPatientInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientInquiry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPatientInquiry.Location = new System.Drawing.Point(670, 87);
            this.buttonPatientInquiry.Name = "buttonPatientInquiry";
            this.buttonPatientInquiry.Size = new System.Drawing.Size(129, 73);
            this.buttonPatientInquiry.TabIndex = 0;
            this.buttonPatientInquiry.Text = "ADD OR UPDATE PATIENT INQUIRY";
            this.buttonPatientInquiry.UseVisualStyleBackColor = false;
            // 
            // buttonSalesReport
            // 
            this.buttonSalesReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalesReport.Location = new System.Drawing.Point(703, 324);
            this.buttonSalesReport.Name = "buttonSalesReport";
            this.buttonSalesReport.Size = new System.Drawing.Size(96, 74);
            this.buttonSalesReport.TabIndex = 1;
            this.buttonSalesReport.Text = "SALES REPORT";
            this.buttonSalesReport.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInquiry
            // 
            this.dataGridViewInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInquiry.Location = new System.Drawing.Point(62, 13);
            this.dataGridViewInquiry.Name = "dataGridViewInquiry";
            this.dataGridViewInquiry.Size = new System.Drawing.Size(501, 204);
            this.dataGridViewInquiry.TabIndex = 2;
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(62, 248);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(501, 204);
            this.dataGridViewSales.TabIndex = 3;
            // 
            // SalesPersonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 492);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.dataGridViewInquiry);
            this.Controls.Add(this.buttonSalesReport);
            this.Controls.Add(this.buttonPatientInquiry);
            this.Name = "SalesPersonScreen";
            this.Text = "SalesPersonScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInquiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPatientInquiry;
        private System.Windows.Forms.Button buttonSalesReport;
        private System.Windows.Forms.DataGridView dataGridViewInquiry;
        private System.Windows.Forms.DataGridView dataGridViewSales;
    }
}