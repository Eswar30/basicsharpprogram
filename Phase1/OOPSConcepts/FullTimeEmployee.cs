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

        public FullTimeEmployee(int id, string name, string dept, int monthlySalary) : base(id, name, dept)
        {
            this.MonthlySalary = monthlySalary;
        }

        public void GetBenifit()
        {
            // Logic
        }
    }
}
