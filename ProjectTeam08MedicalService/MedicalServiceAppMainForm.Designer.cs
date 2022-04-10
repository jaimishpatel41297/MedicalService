namespace ProjectTeam08MedicalService
{
    partial class MedicalServiceAppMainForm
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
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonSalePerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdmin.Location = new System.Drawing.Point(403, 343);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(160, 80);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "ADMIN";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            // 
            // buttonSalePerson
            // 
            this.buttonSalePerson.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSalePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalePerson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalePerson.Location = new System.Drawing.Point(730, 343);
            this.buttonSalePerson.Name = "buttonSalePerson";
            this.buttonSalePerson.Size = new System.Drawing.Size(160, 80);
            this.buttonSalePerson.TabIndex = 1;
            this.buttonSalePerson.Text = "SALES PERSON";
            this.buttonSalePerson.UseVisualStyleBackColor = false;
            // 
            // MedicalServiceAppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.buttonSalePerson);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "MedicalServiceAppMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonSalePerson;
    }
}

