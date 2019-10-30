using System;
using WindowsFormsApp1.usecases.collections;

namespace WindowsFormsApp1.usecases
{
    public class CadastrarProduto
    {
        public CadastrarProduto()
        {
        }

        public Boolean NewProduct(String name, String tipo, String calorias, String classe)
        {
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<Product>("product");
            Product product = new Product();

            if (name == null || name.Equals("")) return false;
            if (tipo == null || tipo.Equals("")) return false;
            if (calorias == null || calorias.Equals("")) return false;
            if (classe == null || classe.Equals("")) return false;

            product.Name = name;
            product.Classe = classe;
            product.Tipo = tipo;
            product.Calorias = float.Parse(calorias, System.Globalization.CultureInfo.InvariantCulture);

            collection.InsertOne(product);
            
            return true;
        }
    }
}