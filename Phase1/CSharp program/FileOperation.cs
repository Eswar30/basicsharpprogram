using System;
using System.Collections.Generic;
using System.IO;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_program
{
    class FileOperation
    {
        public void WriteFile()
        {
            string content = "Name, ID, Dept";
            File.WriteAllText("C://employee//employee.txt", content);
        }
        public void UpdateFile()
        {
            string employee = Environment.NewLine + "\nEswar, 1, CSE";
            File.AppendAllText("C://employee//employee.txt", employee);
        }
        public void ReadFile()
        {
            string content = File.ReadAllText("C://employee//employee.txt");
            Console.WriteLine(content);
            string[] contents = File.ReadAllLines("C://employee//employee.txt");
            foreach (string str in contents)
            {
                Console.WriteLine(str);
            }
        }
            public void DeleteFile()
            {
                if (File.Exists("C://employee//employee.txt"))
                {
                File.Delete("C://employee//employee.txt");
                }
            }
        
    }
}






