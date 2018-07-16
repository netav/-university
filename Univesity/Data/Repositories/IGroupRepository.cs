using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univesity.Domain;

namespace Univesity.Data.Repositories
{
    interface IGroupRepository
    {
        
        List<Group> AllGroups();
    }
}
