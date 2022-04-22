using BILLTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class FullTimeEmployee : Employee, IEmployeeBenefits
    {
        public int MonthlySalary { get; set; }

        public FullTimeEmployee(int id, string name, string dept, int monthlySalary, IFinanceTeam team, IITTeam team1) : base(id, name, dept, team, team1)
        {
            this.MonthlySalary = monthlySalary;
        }

        public void GetBenifit()
        {
            // Logic
        }

        // Method Overloading/ Compiletime polymorphism .  [Name matches, but either number or type of 
        //Signature = Name+Returntype +type and number of arguments]
        public int GetBenifit(string benifitName)
        {
            //Logic 
            return 1; 
        }

        // Runtime polymorphism  or method overriding

        public override void GetSalary()
        {
            Console.WriteLine("Getting salary for fulltimeemployee class");

        }
    }
}
