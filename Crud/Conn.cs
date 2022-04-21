using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    static class Conn
    {
        private const string servidor = "localhost";
        private const string bancoDados = "teste_cadastros";
        private const string usuario = "root";
        private const string senha = "suaSenha";

        static public string strConn = $"server={servidor};User Id={usuario};database={bancoDados};password={senha}";


        

    }
}
