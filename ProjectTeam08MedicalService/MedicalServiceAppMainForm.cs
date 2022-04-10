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
    public partial class MedicalServiceAppMainForm : Form
    {
        public MedicalServiceAppMainForm()
        {
            InitializeComponent();

            this.Text = "Medical Travel App Forms";

            AdminSideFroms adminchildform = new AdminSideFroms();
            SalesPersonScreen saleschildform = new SalesPersonScreen();


            buttonAdmin.Click += (s, e) => AddChildForm(adminchildform);
            buttonSalePerson.Click += (s, e) => AddChildForm(saleschildform);
        }

        private void AddChildForm(Form form)
        {
            var result = form.ShowDialog();
            form.Hide();
        }
    }
}
