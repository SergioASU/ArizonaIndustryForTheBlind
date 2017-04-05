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

        string excelDirectory;
   
        public PayRollForm()
        {
            InitializeComponent();

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
            excelFunctions = new ExcelFunctions(excelDirectory);

            int row = 5;
            int col = 8;
            int saveIndex = hoursWorked.getIndex();

            excelFunctions.insertHour(hoursWorked.getWorkHoursArray(), excelDirectory);

            //hoursWorked.setIndex(saveIndex);
        }

        private void typeOfWorkBackButton_Click(object sender, EventArgs e)
        {
            double result;
            if(Double.TryParse(hoursWorkedTextBox.Text, out result))
            {
                hoursWorked.saveHours(result);
                hoursWorked.changeIndex(-1);

                lblTypeOfWork.Text = hoursWorked.getCurrentTypeOfWork();
                hoursWorkedTextBox.Text = hoursWorked.getCurrentHours().ToString();

                lblTotalHoursChange.Text = hoursWorked.getTotalHours().ToString();
            }
            else
            {
                MessageBox.Show("Please input a number for the hours worked");
            }
        }

        private void typeOfWorkNextButton_Click(object sender, EventArgs e)
        {
            double result;
            if (Double.TryParse(hoursWorkedTextBox.Text, out result))
            {
                hoursWorked.saveHours(result);
                hoursWorked.changeIndex(1);

                lblTypeOfWork.Text = hoursWorked.getCurrentTypeOfWork();
                hoursWorkedTextBox.Text = hoursWorked.getCurrentHours().ToString();

                lblTotalHoursChange.Text = hoursWorked.getTotalHours().ToString();
            }
            else
            {
                MessageBox.Show("Please input a number for the hours worked");
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
    }
}
