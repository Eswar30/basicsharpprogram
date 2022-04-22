using BILLTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    abstract class Employee
    {
        public IITTeam ITTeam { get; set;  }
        public IFinanceTeam FinanceTeam { get; set;  }
        public Employee(int id, string name, string dept, IFinanceTeam team, IITTeam team1)
        {
            this.ID = id;
            this.Name = name;
            this.Department = dept;
            FinanceTeam = team;
            ITTeam = team1;

        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public void DoWork()
        {
            // do work 

        }

        public void GetSalary()
        {
            Console.WriteLine(this.ID);
            // get salary
            Console.WriteLine("Salary Credited");
            FinanceTeam.TakeRequestFromEmployee();
            ITTeam.SolveProblem();

        }

    }
}
