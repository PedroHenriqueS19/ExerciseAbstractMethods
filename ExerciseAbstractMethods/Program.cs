using ExerciseAbstractMethods.Entities.Person;
using ExerciseAbstractMethods.Entities.Persons.JuridicalPerson;
using ExerciseAbstractMethods.Entities.Persons.NaturalPerson;
using System;
using System.Collections.Generic;
namespace ExerciseAbstractMethods
{
    class Program()
    {
        public static void Main(string[] args)
        {
            List<TaxPayers> taxPayers = new List<TaxPayers>(); //criei uma lista para instanciar os dados digitado ao decorrer do programa
            Console.Write($"Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write($"Individual or Company (I/C)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                Console.Write($"Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write($"Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individuals(healthExpenditures, name, anualIncome));//adicionei os dados instanciados na lista dentro da classe
                }
                else
                {
                    Console.Write($"Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Companies(numberOfEmployees, name, anualIncome));//adicionei os dados instanciados na lista dentro da classe
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine($"Taxes Paid:");
            foreach(TaxPayers taxPayer in taxPayers)//foreach criado para percorrer os dados digitados em ambas as listas
            {
                double tax = taxPayer.Tax();
                Console.WriteLine($"{taxPayer.Name}: ${tax:f2}");
                sum += tax;//fiz a soma entre todos os resultados polimóficos 
            }
            Console.WriteLine();
            Console.WriteLine($"Total Taxes: ${sum:f2}");
        }
    }
}