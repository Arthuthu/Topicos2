using Business.Connection;
using Business.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Controller
{
    public class GetAlunos
    {
        public List<Alunos> GetAlunosList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TopicosII")))
            {
                var output = connection.Query<Alunos>($"select * from Alunos").ToList();
                return output;
            }
        }
    }
}
