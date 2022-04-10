namespace ProjectTeam08MedicalService
{
    partial class AddOrUpdateDoctor
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
            this.listBoxDoctor = new System.Windows.Forms.ListBox();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.buttonAddDoctor = new System.Windows.Forms.Button();
            this.buttonUpdateDoctor = new System.Windows.Forms.Button();
            this.labelDoctorPhone = new System.Windows.Forms.Label();
            this.textBoxDoctorPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxDoctor
            // 
            this.listBoxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDoctor.FormattingEnabled = true;
            this.listBoxDoctor.ItemHeight = 18;
            this.listBoxDoctor.Location = new System.Drawing.Point(461, 53);
            this.listBoxDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDoctor.Name = "listBoxDoctor";
            this.listBoxDoctor.Size = new System.Drawing.Size(293, 310);
            this.listBoxDoctor.TabIndex = 0;
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorName.Location = new System.Drawing.Point(458, 421);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(109, 18);
            this.labelDoctorName.TabIndex = 1;
            this.labelDoctorName.Text = "Doctor Name";
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoctorName.Location = new System.Drawing.Point(600, 421);
            this.textBoxDoctorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.Size = new System.Drawing.Size(171, 24);
            this.textBoxDoctorName.TabIndex = 2;
            // 
            // buttonAddDoctor
            // 
            this.buttonAddDoctor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddDoctor.Location = new System.Drawing.Point(461, 571);
            this.buttonAddDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDoctor.Name = "buttonAddDoctor";
            this.buttonAddDoctor.Size = new System.Drawing.Size(123, 52);
            this.buttonAddDoctor.TabIndex = 3;
            this.buttonAddDoctor.Text = "Add Doctor";
            this.buttonAddDoctor.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateDoctor
            // 
            this.buttonUpdateDoctor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdateDoctor.Location = new System.Drawing.Point(630, 571);
            this.buttonUpdateDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateDoctor.Name = "buttonUpdateDoctor";
            this.buttonUpdateDoctor.Size = new System.Drawing.Size(124, 52);
            this.buttonUpdateDoctor.TabIndex = 4;
            this.buttonUpdateDoctor.Text = "Update Doctor";
            this.buttonUpdateDoctor.UseVisualStyleBackColor = false;
            // 
            // labelDoctorPhone
            // 
            this.labelDoctorPhone.AutoSize = true;
            this.labelDoctorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorPhone.Location = new System.Drawing.Point(461, 496);
            this.labelDoctorPhone.Name = "labelDoctorPhone";
            this.labelDoctorPhone.Size = new System.Drawing.Size(107, 17);
            this.labelDoctorPhone.TabIndex = 5;
            this.labelDoctorPhone.Text = "Doctor Phone";
            // 
            // textBoxDoctorPhone
            // 
            this.textBoxDoctorPhone.Location = new System.Drawing.Point(600, 496);
            this.textBoxDoctorPhone.Name = "textBoxDoctorPhone";
            this.textBoxDoctorPhone.Size = new System.Drawing.Size(171, 22);
            this.textBoxDoctorPhone.TabIndex = 6;
            // 
            // AddOrUpdateDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 750);
            this.Controls.Add(this.textBoxDoctorPhone);
            this.Controls.Add(this.labelDoctorPhone);
            this.Controls.Add(this.buttonUpdateDoctor);
            this.Controls.Add(this.buttonAddDoctor);
            this.Controls.Add(this.textBoxDoctorName);
            this.Controls.Add(this.labelDoctorName);
            this.Controls.Add(this.listBoxDoctor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrUpdateDoctor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDoctor;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.Button buttonAddDoctor;
        private System.Windows.Forms.Button buttonUpdateDoctor;
        private System.Windows.Forms.Label labelDoctorPhone;
        private System.Windows.Forms.TextBox textBoxDoctorPhone;
    }
}