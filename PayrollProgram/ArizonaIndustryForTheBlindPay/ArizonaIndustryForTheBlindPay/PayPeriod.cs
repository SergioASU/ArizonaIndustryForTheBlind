using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizonaIndustryForTheBlindPay
{
    class PayPeriod
    {
        public int period;
        public PayPeriod()
        {
            period = 0;
        }

        public void savePayPeriod(int payPeriod)
        {
            this.period = payPeriod;
        }

        public int getPayPeriod()
        {
            return this.period;
        }
    }
}
