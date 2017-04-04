using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizonaIndustryForTheBlindPay
{
    class ChooseName
    {
        private string name;
        public ChooseName()
        {
            name = "";
        }

        public void saveName(string employeeName)
        {
            name = employeeName;
        }

        public string getName()
        {
            return name;
        }


    }
}
