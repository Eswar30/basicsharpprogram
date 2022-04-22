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

        private int _ID;

        public int ID
        {

            get
            {
                // if (user is valid)
                return this._ID;
            }
            set
            {
                if (!this.Validate(value))
                {
                    throw new Exception("Invalid Value");
                }
                this._ID = value;
            }

        }

        private bool Validate(int id)
        {
            // db calls
            if( id < 1)
            {
                return false;
            }
            return true;
        }
        public string Name { get; set; }

        public string Department { get; set; }

        public void DoWork()
        {
            // do work 

            // ITTeam.SolveProblem();
            //Console.WriteLine(this.ID);
            // get IT problem
           // Console.WriteLine("IT issues");
           // ITTeam.SolveProblem();


        }

        public virtual void GetSalary()
        {
            Console.WriteLine(this.ID);
            // get salary
            Console.WriteLine("Salary Credited");
            FinanceTeam.TakeRequestFromEmployee();
            ITTeam.SolveProblem();

        }

    }
}
