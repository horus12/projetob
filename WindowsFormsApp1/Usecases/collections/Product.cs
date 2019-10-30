using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1.usecases.collections
{
    public class Product
    {
        public Product()
        {
        }

        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Tipo { get; set; }
        public string Classe { get; set; }
        public float Calorias { get; set; }
        
    }
}