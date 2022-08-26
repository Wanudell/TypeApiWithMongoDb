using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.Entities.Abstracts;
using Types.Entities.Enums;

namespace Types.Entities.Entities
{
    public class User : MongoDbEntity
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}