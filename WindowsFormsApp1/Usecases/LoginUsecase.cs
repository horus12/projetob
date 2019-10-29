using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class LoginUsecase
    {
        public LoginUsecase()
        {

        }

        public User Login(string cpf , string senha)
        {
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<User>("user");

            var filter = new BsonDocument("Cpf", cpf);
            var results = collection.Find(filter).ToList();
            if (results.Count == 0)
                throw new Exception("Usuario inesistente ");

            User user = results.First();

            Cript cript = new Cript();

            if (user.UserStatus==UserStatus.DELETED)
                throw new Exception("Usuario inesistente ");

            if (user.UserStatus==UserStatus.BLOQUED)
                throw new Exception("Usuario Bloqueado");

            if (!user.Password.Equals(cript.ComputeSha256Hash(senha)))
                throw new Exception("Senha Invalida");


            return user;
        }


    }
}
