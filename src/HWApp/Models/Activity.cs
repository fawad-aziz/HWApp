using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HWApp.Models
{
    public class Activity
    {
		public ObjectId Id { get; set; }

		[BsonElement("ActivityId")]
		public int ActivityId { get; set; }

		[BsonElement("ActivityName")]
		public string ActivityName { get; set; }
    }
}
