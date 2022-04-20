using System;

namespace OOPSConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee e = new FullTimeEmployee(1,"Eswar", "CSE", 5000);
            e.GetSalary();
        }
    }
}
