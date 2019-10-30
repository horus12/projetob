using System;
using System.Linq;
using WindowsFormsApp1.exceptions;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    class LoginUsecase
    {
        public LoginUsecase()
        {
        }

        public User Login(string cpf, string senha)
        {
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<User>("user");

            var filter = new BsonDocument("Cpf", cpf);
            var results = collection.Find(filter).ToList();
            if (results.Count == 0)
                throw new Exception("Usuario inexistente ");

            User user = results.First();

            Cript cript = new Cript();

            if (user.UserStatus == UserStatus.DELETED)
                throw new Exception("Usuario inexistente ");

            if (user.UserStatus == UserStatus.BLOQUED)
                throw new Exception("Usuario Bloqueado");

            if (!user.Password.Equals(cript.ComputeSha256Hash(senha)))
                throw new WrongcredentialsException("Senha Invalida");


            return user;
        }
    }
}