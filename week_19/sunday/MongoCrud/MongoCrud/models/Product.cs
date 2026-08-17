using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoCrud.models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }
        [BsonElement("name")]
        public string Name {  get; set; }
        [BsonElement("category")]
        public string Category { get; set; }
        [BsonElement("price")]
        public double Price {  get; set; }
        [BsonElement("stock")]
        public int Stock {  get; set; }
        [BsonElement("rating")]
        public double Rating {  get; set; }
        [BsonElement("isActive")]
        public bool IsActive {  get; set; }
        [BsonElement("createdAt")]
        public object CreatedAt {  get; set; }

    }
}
