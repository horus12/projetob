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

        public String cadastro(User user) {
            var collection = database.GetCollection<User>("user");
            if (user.Cpf == null || user.Cpf.Equals(""))
               return "invalid_cpf";
            if (user.Password == null || user.Password.Equals(""))
                return "invalid_password";
            if (user.Rg == null || user.Rg.Equals(""))
                return "invalid_rg";
            if (user.Name == null || user.Name.Equals(""))
                return "invalid_name";
            var filter = new BsonDocument("Cpf", user.Cpf);
            var results = collection.Find(filter).ToList();
            if (results.Count > 0)
                return "user_existent";

            Cript cript = new Cript();


            user.Password = cript.ComputeSha256Hash(user.Password);
            user.StartDate = DateTime.Now.Date;
            user.UserStatus = UserStatus.NORMAL;
            user.Profile = 2;
           
            collection.InsertOne(user);
            

            return "success";
        }
    }
}
