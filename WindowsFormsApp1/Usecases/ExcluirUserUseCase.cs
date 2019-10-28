using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var filter = new BsonDocument("Cpf", cpf);
            var results = collection.Find(filter).ToList();
            if (results.Count == 0)
                return Status.NOTFOUND;


            try
            {
                collection.DeleteOne(filter);
            }
            catch (Exception e)
            {
                return Status.ERROR;
            }

            return Status.OK;
        }
    }


}
