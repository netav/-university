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

        public List<Group> AllGroups()
        {
            var AllGroups = _context.Groups;
            var SorterGroup = from u in AllGroups
                                .Include("Faculty")
                                .Include("Students")
                                select u;
            return SorterGroup.ToList();
        }

       

        
    }
}
