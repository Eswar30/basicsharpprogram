using BILLTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class PartTimeEmployee : Employee, IEmployeeBenefits
    {
        public int HourlySalary { get; set; }

        public PartTimeEmployee(int id, string name, string dept, int hourlySalary, IFinanceTeam team, IITTeam team1) : base(id, name, dept, team, team1)
        {
            this.HourlySalary = hourlySalary;
        }

        public void GetBenifit()
        {
            throw new NotImplementedException();
        }
    }
}
