using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArizonaIndustryForTheBlindPay
{
    struct payTypes
    {
        double inderect;
        double direct;
        double annualLeave;
        double sickLeave;
        double familySickLeave;
        double overtime;
        double holidayWithPay;
        double other;
        double leaveWithoutPay;
    }
    class HoursWorked
    {
        private static readonly int NUMBER_OF_DAYS = 14;
        private static readonly int NUMBER_OF_HOURS = 9;
        List<KeyValuePair<string, double[][]>> list;
        private string[] typeOfWork;
        private double[] hoursWorkedArray;
        private int indexWork;

        private double[][] name1Work;
        private double[][] name2Work;
        private double[][] name3Work;
        private double[][] name4Work;
        private double[][] name5Work;

        public HoursWorked()
        {
            name1Work = new double[NUMBER_OF_HOURS][];
            name2Work = new double[NUMBER_OF_HOURS][];
            name3Work = new double[NUMBER_OF_HOURS][];
            name4Work = new double[NUMBER_OF_HOURS][];
            name5Work = new double[NUMBER_OF_HOURS][];

            for (int i = 0; i < 9; i++)
            {
                name1Work[i] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0 };
                name2Work[i] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0 };
                name3Work[i] = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                name4Work[i] = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                name5Work[i] = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
            list = new List<KeyValuePair<string, double[][]>>()
            {
                new KeyValuePair<string, double[][]>("name1", name1Work),
                new KeyValuePair<string, double[][]>("name2", name2Work),
                new KeyValuePair<string, double[][]>("name3", name3Work),
                new KeyValuePair<string, double[][]>("name4", name4Work),
                new KeyValuePair<string, double[][]>("name5", name5Work),
            };
        }

        public void setHours(string name, int day, int typeOfWork,double amountOfHours)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(list.ElementAt(i).Key.Equals(name))
                {
                    list.ElementAt(i).Value[typeOfWork][day] = amountOfHours;
                    MessageBox.Show(list.ElementAt(i).Key.ToString() + ": " + typeOfWork + " " + day + " " + list.ElementAt(i).Value[typeOfWork][day].ToString());
                }
            }
        }
    }
}
