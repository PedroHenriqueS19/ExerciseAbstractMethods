using ExerciseAbstractMethods.Entities.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExerciseAbstractMethods.Entities.Persons.JuridicalPerson
{
    class Companies : TaxPayers
    {
        public int NumberOfEmployees { get; set; }

        public Companies() { }
        public Companies(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            if (NumberOfEmployees > 10) { return AnualIncome * 0.14; }
            else { return AnualIncome * 0.16; }
        }
    }
}