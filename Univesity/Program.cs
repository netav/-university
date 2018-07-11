using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univesity.Data.Repositories;

namespace Univesity
{
    class Program
    {
        static void Main(string[] args)
        {
            var Student = new StudentRepository();
            var AllStudent = Student.GetStudentForName();
            foreach (var student in AllStudent)
            {
                Console.WriteLine("First name: {0}\n\rLast Name: {1}\n\rStudent card Number: {2}\r\nGroup: {3}\r\n ",
                    student.FirstName,
                    student.LastName,
                    student.CardNumber,
                    student.Group.Name);
                
            }
            


            Console.ReadLine();
        }
    }
}
