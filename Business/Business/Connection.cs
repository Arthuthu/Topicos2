using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public class Connection
    {
        public SqlConnection banco;



        public Connection()
        {
            banco = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TopicosII;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
    }
}
