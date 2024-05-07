using ExerciseAbstractMethods.Entities.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExerciseAbstractMethods.Entities.Persons.NaturalPerson
{
    class Individuals : TaxPayers
    {
        public double HealthExpenditures { get; set; }
        public Individuals() { }
        public Individuals(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            if (AnualIncome < 20000.00) { return (AnualIncome * 0.15) - (HealthExpenditures * 0.5); }
            else { return (AnualIncome * 0.25) - (HealthExpenditures * 0.5); }
        }
    }
}