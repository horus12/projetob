using MongoDB.Driver;
using System;
using System.Configuration;
using MongoDB.Driver.Core;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using MongoDB.Bson;

namespace WindowsFormsApp1
{

    class Mongo
    {

        public Mongo()
        {

        }

        public IMongoDatabase getserver() {
            var client = new MongoClient();

             IMongoDatabase db = client.GetDatabase("projetob");
             var collection = db.GetCollection<BsonDocument>("user");


            return db;
        }
    }
}
