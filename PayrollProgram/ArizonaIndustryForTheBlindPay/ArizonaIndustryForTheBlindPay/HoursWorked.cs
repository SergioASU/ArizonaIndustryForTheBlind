using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizonaIndustryForTheBlindPay
{
    class HoursWorked
    {
        private string[] typeOfWork;
        private double[] hoursWorkedArray;
        private int indexWork;
        public HoursWorked()
        {
            typeOfWork = new string[9] {"Indirect Hours", "Direct Hours", "Annual Leave Taken",
                "Sick Leave - Self", "Family Sick Leave" , "Overtime","Holiday Absense w/Pay", "Other", "Leave Without Pay" };

            hoursWorkedArray = new double[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            indexWork = 0;
        }

        public void saveHours(double hours)
        {
            hoursWorkedArray[indexWork] = hours;
        }

        public string getCurrentTypeOfWork()
        {
            return typeOfWork[indexWork];
        }

        public double getCurrentHours()
        {
            return hoursWorkedArray[indexWork];
        }

        public double getTotalHours()
        {
            double total = 0;
            for(int i = 0; i < hoursWorkedArray.Length; i++)
            {
                total += hoursWorkedArray[i];
            }

            return total;
        }

        public void changeIndex(int direction)
        {
            if (direction < 0 && indexWork > 0)
            {
                indexWork--;
            }
            else if(direction > 0 && indexWork < typeOfWork.Length - 1)
            {
                indexWork++;
            }
        }
    }
}
