using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1
{
    public class User
    {

        [BsonConstructor]
        public User(string name, string password, string cpf, string rg) {
            Name = name;
            Password = password;
            Cpf = cpf;
            Rg = rg;
        }
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public BsonDateTime StartDate { get; set; }
        public UserStatus UserStatus { get; set; }
        public int Profile { get; set; }

    }
}
