using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CadastrarUsuario
    {
        public CadastrarUsuario() {
        }

        public Boolean cadastro(User user) {

            if (user.cpf == null || !user.cpf.Equals(""))
                return false;

            return true;
        }
    }
}
