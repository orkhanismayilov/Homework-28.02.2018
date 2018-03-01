using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            WageTax wt = new WageTax(DailyS: 38.5, WorkD: 12);
            Console.WriteLine(wt.Tax);
        }
    }

    class WageTax
    {
        public double DailyS { get; set; }
        public int WorkD { get; set; }
        private string tax { get; set; }

        public string Tax
        {
            get
            {
                this.TaxCalc();
                return this.tax;
            }
        }

        public WageTax(double DailyS, int WorkD)
        {
            this.DailyS = DailyS;
            this.WorkD = WorkD;
        }

        public void TaxCalc()
        {
            if (DailyS != 0 && WorkD != 0)
            {
                double total = DailyS * WorkD;
                if (total < 1000)
                {
                    tax = "Tax: " + (total * 0.18);
                }else if (total > 1000)
                {
                    tax = "Tax: " + (total - 1000) * 0.04;
                }
            }
            else
            {
                tax = "Invalid inputs";
            }
        }
    }
}
