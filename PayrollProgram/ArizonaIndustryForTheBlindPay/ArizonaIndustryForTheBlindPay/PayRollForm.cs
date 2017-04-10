using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArizonaIndustryForTheBlindPay
{
    public partial class PayRollForm : Form
    {
        PayPeriod payPeriod;
        ChooseName chooseName;
        HoursWorked hoursWorked;
        ExcelFunctions excelFunctions;

        string[] daysArray;
        string[] typesOfWorkArray;
        int daysIndex;
        int workIndex;

        string excelDirectory;

        double totalHours = 0;
   
        public PayRollForm()
        {
            InitializeComponent();

            daysArray = new string[] {"Day 1", "Day 2", "Day 3", "Day 4", "Day 5", "Day 6", "Day 7", "Day 8", "Day 8", "Day 9",
            "Day 10","Day 11","Day 12","Day 13","Day 14",};

            typesOfWorkArray = new string[] {"Indirect", "Direct", "Annual Leave", "Sick Leave", "Family Sick Leave", "Overtime",
            "Holiday With Pay", "Other", "Leave Without Pay"};

            daysIndex = 0;
            workIndex = 0;

            lblTypeOfWork.Text = typesOfWorkArray[workIndex];
            lblPeriodDay.Text = daysArray[daysIndex];

            payPeriod = new PayPeriod();
            hoursWorked = new HoursWorked();
            chooseName = new ChooseName();
            excelDirectory = "";

            namesListBox.SetSelected(0, true);
            payPeriodTextBox.Text = "0";
            hoursWorkedTextBox.Text = "0";

        }

        private void payPeriodNextButton_Click(object sender, EventArgs e)
        {
            namePanel.Visible = true;

            int result;

            if (Int32.TryParse(payPeriodTextBox.Text, out result))
            {
                payPeriod.savePayPeriod(result);
                System.Windows.Forms.MessageBox.Show(payPeriod.getPayPeriod().ToString());
            }
            else
            {
                //Text was not a number
            }
        }

        private void namePanelBackButton_Click(object sender, EventArgs e)
        {
            namePanel.Visible = false;

            chooseName.saveName(namesListBox.SelectedItem.ToString());

            System.Windows.Forms.MessageBox.Show(chooseName.getName());
        }

        private void namePanelNextButton_Click(object sender, EventArgs e)
        {
            hoursWorkedPanel.Visible = true;

            chooseName.saveName(namesListBox.SelectedItem.ToString());

            System.Windows.Forms.MessageBox.Show(chooseName.getName());
        }

        private void hoursWorkedBackButton_Click(object sender, EventArgs e)
        {
            hoursWorkedPanel.Visible = false;
        }

        private void hoursWorkedOkButton_Click(object sender, EventArgs e)
        {
            
        }

        private void typeOfWorkBackButton_Click(object sender, EventArgs e)
        {
            if (workIndex > 0)
            {
                workIndex--;
                lblTypeOfWork.Text = typesOfWorkArray[workIndex];
            }
        }

        private void typeOfWorkNextButton_Click(object sender, EventArgs e)
        {
            if (workIndex < typesOfWorkArray.Length - 1)
            {
                workIndex++;
                lblTypeOfWork.Text = typesOfWorkArray[workIndex];
            }
        }

        private void chooseExcelButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                excelDirectory = openFileDialog1.FileName;
                MessageBox.Show(excelDirectory);
            }
        }

        private void dayButtonBack_Click(object sender, EventArgs e)
        {
            if (daysIndex > 0)
            {
                daysIndex--;
                lblPeriodDay.Text = daysArray[daysIndex];
            }
        }

        private void dayButtonNext_Click(object sender, EventArgs e)
        {
            if (daysIndex < daysArray.Length - 1)
            {
                daysIndex++;
                lblPeriodDay.Text = daysArray[daysIndex];
            }
        }

        private void setHoursButton_Click(object sender, EventArgs e)
        {
            double result;
            if (Double.TryParse(hoursWorkedTextBox.Text, out result))
            {
                hoursWorked.setHours(chooseName.getName(), daysIndex, workIndex, result);
                totalHours += result;
                lblTotalHours.Text = totalHours.ToString();
            }
        }
    }
}
