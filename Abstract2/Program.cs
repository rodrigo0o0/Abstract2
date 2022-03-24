using Abstract2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Payer> payers = new List<Payer>();
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Anual Income : ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(type == 'i')
                {
                    Console.Write("Health Expenditures : ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    payers.Add(new Individual(name,anualIncome,healthExpenditures));
                }else if(type == 'c')
                {
                    Console.Write("Number o employees : ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name,anualIncome,numberOfEmployees));
                }
                else
                {
                    Console.WriteLine("ERRORRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR");
                }
               


            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sumTaxes = 0.0;
            foreach (var p in payers)
            {
                Console.WriteLine($"{p.Name}: $ {p.Taxes().ToString("F2",CultureInfo.InvariantCulture)}");
                sumTaxes += p.Taxes();
            }
            Console.WriteLine("TOTAL TAXES : $ "+ sumTaxes.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
