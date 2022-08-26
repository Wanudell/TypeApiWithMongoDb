using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.Entities.Entities;
using Types.Entities.Repository;

namespace Types.Data.Access.Abstractions
{
    public interface IAdminService : IRepository<User, string>
    {
    }
}