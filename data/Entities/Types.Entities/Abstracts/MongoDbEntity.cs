using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types.Entities.Abstracts
{
    public abstract class MongoDbEntity : IEntity<string>
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}