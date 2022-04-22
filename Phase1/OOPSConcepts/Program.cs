using BILLTest;
using System;

namespace OOPSConcepts
{
    class Program
    {
        static void M
            ain(string[] args)
        {
            FullTimeEmployee e = new FullTimeEmployee(2,"Eswar", "CSE", 5000, (IFinanceTeam)DependencyResolver.GetInstance("IFinanceTeam"), (IITTeam)ITTeamDependcy.GetInstance("IITTeam"));
            e.GetSalary();
            Console.WriteLine(e.ID);
            e.GetBenifit();
        }
    }
}
