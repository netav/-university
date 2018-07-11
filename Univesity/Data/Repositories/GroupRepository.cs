using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univesity.Domain;

namespace Univesity.Data.Repositories
{
    class GroupRepository : IGroupRepository
    {
        private AppDbContext _context;

        public GroupRepository()
        {
            _context = new AppDbContext();
        }
        public List<Group> GetAllGroups()
        {
            var AllGroups = from u in _context.Groups
                            .Include("Faculty")
                            .Include("Students")
                            select u;
            return AllGroups.ToList();




        }
    }
}
