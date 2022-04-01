using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_program
{
    class StudentDetails
    {
        public void GetStudentDetails()
        {
            Console.WriteLine("Please Enter Student ID Name and dept separated by , Enter 0 to exit");
            bool keepRunning = true;
            while (keepRunning)
            {
                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine("CLOSING THE WINDOW");
                    keepRunning = false;
                    break;
                }
                File.WriteAllText("C://StudentDetails//student.txt", input);
                Console.WriteLine("Entered Studed detail displayed below check it if you want to update enter the correct detail with same ID, Enter 0 to exit");

                DisplayContent();

                input = Console.ReadLine();
                string[] updatedDetails = input.Split(',');
                string[] content = File.ReadAllLines("C://StudentDetails//student.txt");

                for (int i = 0; i <= 2; i++)
                {
                    string[] eachString = content[i].Split(',');
                    if (eachString[0] == updatedDetails[0])
                    {
                        content[i] = input;
                        File.WriteAllLines("C://StudentDetails//student.txt", content);
                        break;
                    }

                }

                Console.WriteLine("Updated Studed detail displayed below check it if you want to update enter the correct detail with same ID, Enter 0 to exit");
                DisplayContent();
            }
        }

        private void DisplayContent()
        {
            string[] content = File.ReadAllLines("C://StudentDetails//student.txt");
            foreach (string c in content)
            {
                string[] eachString = c.Split(',');
                foreach (string s in eachString)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public void DeleteFile()
        {
            if (File.Exists("C://StudentDetails//student.txt"))
            {
                File.Delete("C://StudentDetails//student.txt");
            }
        }
    }
}
