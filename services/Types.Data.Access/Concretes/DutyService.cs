using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Types.Data.Access.Abstractions;
using Types.Entities;
using Types.Entities.Concretes;
using Types.Entities.Entities;

namespace Types.Data.Access.Concretes
{
    public class DutyService : MongoDbRepositoryBase<Duty>, IDutyService
    {
        public DutyService(IOptions<MongoDbSettings> options) : base(options)
        {
        }
    }
}