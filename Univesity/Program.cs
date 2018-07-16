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
            #region Student Table
            var Student = new StudentRepository();
            var AllStudent = Student.GetStudentForName();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|               All students               |");            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("____________________________________________");
            Console.WriteLine("|First name |   Last Name  |Card № | Group |");
            
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var student in AllStudent)
            {
                
                Console.WriteLine("| {0,10}|{1,13} |{2,6} |{3,7}|",
                    student.FirstName,
                    student.LastName,
                    student.CardNumber,
                    student.Group.Name);
                
            }
            Console.WriteLine("____________________________________________");
            Console.ResetColor();
            #endregion

            #region Group Table
            var Groups = new GroupRepository();
            var AllGroup = Groups.AllGroups();
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("|Group Name|          Faculties       |Group|");
            foreach (var group in AllGroup)
            {
                Console.WriteLine("| {0,9}|{1,26}|{2,5}|",
                    group.Name , 
                    group.Faculty.Name ,
                    group.Students.Count());
            }
            #endregion

            Console.ReadLine();
        }
    }
}
