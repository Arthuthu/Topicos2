using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Connection
    {
        public SqlConnection Conexao()
        {
            var output = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=TopicosII;Trusted_Connection=True");
            return output;
        }
    }
}
