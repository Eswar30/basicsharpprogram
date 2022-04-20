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

        public PartTimeEmployee(int id, string name, string dept, int hourlySalary) : base(id, name, dept)
        {
            this.HourlySalary = hourlySalary;
        }

        public void GetBenifit()
        {
            throw new NotImplementedException();
        }
    }
}
