using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    public class DesbloqueioUseCase
    {
        public void unblock(string cpf, string email)
        {
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<User>("user");
            var filter = new BsonDocument("Cpf", cpf);
            var results = collection.Find(filter).ToList();
            if (results.Count == 0)
                throw new Exception();

            User user = results.First();

            user.UserStatus = UserStatus.NORMAL;

            var userFilter = Builders<User>.Filter.Eq(s => s.Id, user.Id);
            collection.ReplaceOne(userFilter, user);

            var emailSender = new Email();
            var body = "Olá " + user.Name + " seu usuário foi desbloqueado com sucesso!";
            emailSender.email_send(email,"Desbloqueio","",body);
        }
    }
}