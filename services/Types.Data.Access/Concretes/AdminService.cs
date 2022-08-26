using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.Data.Access.Abstractions;
using Types.Entities;
using Types.Entities.Concretes;
using Types.Entities.Entities;

namespace Types.Data.Access.Concretes
{
    public class AdminService : MongoDbRepositoryBase<User>, IAdminService
    {
        public AdminService(IOptions<MongoDbSettings> options) : base(options)
        {
        }
    }
}