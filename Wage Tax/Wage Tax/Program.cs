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
            WageTax wt = new WageTax(DailyS: 45, WorkD: 12);
            Console.WriteLine("Tax: " + wt.Tax);
            Console.WriteLine("Profit: " + wt.Profit);
        }
    }

    class WageTax
    {
        public double DailyS { get; set; }
        public int WorkD { get; set; }
        private double tax { get; set; }
        private double profit { get; set; }

        public double Tax
        {
            get
            {
                this.TaxCalc();
                return this.tax;
            }
        }

        public double Profit
        {
            get
            {
                this.TaxCalc();
                return this.profit;
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
                    tax = total * 0.18;
                }else if (total > 1000)
                {
                    tax = (total - 1000) * 0.04;
                }
                profit = total - tax;
            }
            else
            {
                Console.WriteLine("Invalid inputs");
            }
        }
    }
}
