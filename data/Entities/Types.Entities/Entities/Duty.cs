using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.Entities.Abstracts;

namespace Types.Entities.Entities
{
    public class Duty : MongoDbEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadlineDate { get; } = DateTime.Now.AddDays(7);
    }
}