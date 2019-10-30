using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.usecases.collections
{
    
    public class UserHistory
    {

        [BsonConstructor]
        public UserHistory()
        {
           
        }
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public BsonDateTime CreatedDate { get; set; }
        public BsonDateTime DeletedDate { get; set; }
        public UserStatus UserStatus { get; set; }
        public int Profile { get; set; }

    }
}
