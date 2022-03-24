using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2.Entities
{
    internal abstract class Payer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Payer() { }

        protected Payer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();
    }
}
