using System;
using WindowsFormsApp1.usecases.collections;
using MongoDB.Bson;

namespace WindowsFormsApp1.usecases
{
    public class AlterarProdutoUseCase
    {
        public AlterarProdutoUseCase()
        {
        }
        
        public Boolean NewProduct(String name, String tipo, String calorias, String classe, ObjectId id)
        {
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<Product>("product");
            Product product = new Product();

            if (name == null || name.Equals("")) return false;
            if (tipo == null || tipo.Equals("")) return false;
            if (calorias == null || calorias.Equals("")) return false;
            if (classe == null || classe.Equals("")) return false;
            product.Id = id;
            product.Name = name;
            product.Classe = classe;
            product.Tipo = tipo;
            product.Calorias = float.Parse(calorias, System.Globalization.CultureInfo.InvariantCulture);
            var filter = new BsonDocument("_id", id); 
            collection.ReplaceOne(filter, product);
            
            return true;
        }
    }
}