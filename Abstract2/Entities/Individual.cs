using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2.Entities
{
    internal class Individual : Payer
    {

        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double taxes = 0;
            if(base.AnualIncome < 20000)
            {
                taxes = base.AnualIncome * 0.15;
            }
            else
            {
                taxes = base.AnualIncome * 0.25;
            }
            taxes -= HealthExpenditures * 0.5;
            return taxes;
        }
    }
}
