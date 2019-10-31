using System;
using System.Linq;
using WindowsFormsApp1.usecases.collections;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1.usecases
{
    public class ExcuirProduto
    {
        public ExcuirProduto()
        {
            
        }

        public Boolean Excluir(Product product)
        {

            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<Product>("product");
            
            var filter = new BsonDocument("_id", product.Id);
            var results = collection.Find(filter).ToList();
            if (results.Count == 0)
                return false;

            collection.DeleteOne(filter);
            
            
            return true;
        }

    }
}