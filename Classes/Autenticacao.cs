using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstoqueLogin
{
    public static class Autenticacao
    {
        public static bool Login(string email, string senha)
        {
            // Aqui você deve adicionar a lógica para validar o login com o banco de dados
            if (email == "joao@evergreen.com" && senha == "senha123")
            {
                return true; // Login bem-sucedido
            }
            else
            {
                return false; // Login falhou
            }
        }
    }

}
