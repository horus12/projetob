using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.usecases.collections;

namespace WindowsFormsApp1.usecases
{
    class ExcluirUserUseCase
    {

        public ExcluirUserUseCase()
        {

        }

        public Status DeletarUser(string cpf)
        {
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<User>("user");
            var collectionHistory = database.GetCollection<UserHistory>("userHistory");

            var filter = new BsonDocument("Cpf", cpf);
            var results = collection.Find(filter).ToList();
            if (results.Count == 0)
                return Status.NOTFOUND;

            User user = results.First();

            user.UserStatus = UserStatus.DELETED;

            collection.ReplaceOne(filter,user);

            UserHistory userHistory = new UserHistory(user);

            collectionHistory.InsertOne(userHistory);
           

            return Status.OK;
        }
    }


}
