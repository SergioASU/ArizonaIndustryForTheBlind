using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArizonaIndustryForTheBlindPayroll
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void PayPeriodForm_Load(object sender, EventArgs e)
        {
          
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            namePanel.Visible = true;
        }

        private void backButtonNamePanel_Click(object sender, EventArgs e)
        {
            namePanel.Visible = false;
        }

        private void nextButtonNamePanel_Click(object sender, EventArgs e)
        {
            hoursWorkedPanel.Visible = true;
        }

        private void backButtonHoursWorked_Click(object sender, EventArgs e)
        {
            hoursWorkedPanel.Visible = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
