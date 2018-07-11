using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Univesity.Domain;
using System.Threading.Tasks;

namespace Univesity.Data.Repositories
{
    class StudentRepository : IStudentRepository
    {
        private AppDbContext _context;

        public StudentRepository()
        {
            _context = new AppDbContext();
        }

        public List<Student> GetStudentForName()
        {
            var AllStudent = _context.Students;
            var SorterStudent = from u in AllStudent
                                .Include("Group")                                
                                orderby u.FirstName
                                select u;
            return SorterStudent.ToList() ;             
        }

        public List<Student> GetStudentsForCard()
        {
            var AllStudent = _context.Students;
            var SorterStudent = from u in AllStudent
                                .Include("Group")
                                orderby u.CardNumber
                                select u;
            return SorterStudent.ToList();
        }
    }
}
