using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2.Entities
{
    internal class Company : Payer
    {
        public int NumberOfEmployees { get; set; }
        public Company()
        {
        }

        public Company(string name, double anualIncome,int numberOfEmplyees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmplyees;
        }

        public override double Taxes()
        {
            if (NumberOfEmployees < 10)
            {
                return base.AnualIncome * 0.16;
            }
            else 
            {
                return base.AnualIncome * 0.14;
            }
        }
    }
}
