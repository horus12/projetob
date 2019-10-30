using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

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
//            var result = validatePasswordStrenght(user.Password);
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

        private String validatePasswordStrenght(string userPassword)
        {
            int total = 10;
            if (userPassword.Length < 7 && userPassword.Length > 11)
            {
                total -= 2;
                return "Tamanho Incorreto";
            }

            if (userPassword.Any(Char.IsWhiteSpace))
            {
                total -= 2;
                return "Senha não pode conter espaços em branco";
            }

            if (userPassword.Any(Char.IsLetterOrDigit))
            {
                total -= 1;
                return "Senha não pode conter caracteres especiais";
            }
            
            var digits = userPassword.Count(Char.IsDigit);
            var letters = userPassword.Count(Char.IsLetter);
            if (letters < 3 && digits < 2)
            {
                total -= 2;
                return "Senha precisa conter no minimo 3 letras e no minimo 2 números";
            }

            if (userPassword.GroupBy(letter => letter).Any(letter2 => letter2.Count() > 2))
            {
                total -= 2;
                return "Não pode haver mais de 3 letras / números repetidos";
            }
            return null;
        }
    }
}
