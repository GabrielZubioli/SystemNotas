using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas
{
    static class ConexaoBanco
    {

        private const string server = "localhost";
        private const string database = "dbsystemnotas";
        private const string user = "root";
        private const string password = "99458163";

        static public string bancoServidor = $"server = {server}; user id={user}; database={database}; password={password}";
    }
}

