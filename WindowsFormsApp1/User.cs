using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace WindowsFormsApp1
{
    class User
    {
    
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public BsonDateTime startDate { get; set; }
        public int userStatus { get; set; }
        public int profile { get; set; }

    }
}
