using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaLibrary
{
    public class Conexao
    {
        //Variavel publica do tipo SqlConnection
        public SqlConnection banco;

        //Metódo de conexão do banco (connectionString disponivel em properties da database TopicosII)
        public Conexao()
        {
            banco = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PizzariaData;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
