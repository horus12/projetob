using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CadastrarUsuario
    {
        IMongoDatabase database;

        public CadastrarUsuario(IMongoDatabase database)
        {
            this.database = database;
        }

        public void cadastro(User user) {
            var collection = database.GetCollection<BsonDocument>("user");
            if (user.Cpf == null || user.Cpf.Equals(""))
               return;

            var userDb = new BsonDocument();
            userDb.Add("Name", user.Name);
            userDb.Add("Password", user.Password);
            userDb.Add("Cpf", user.Cpf);
            collection.InsertOne(userDb);
            collection.Find();
            return;
        }
    }
}
