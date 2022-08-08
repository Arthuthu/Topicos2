using Business.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public class GetAlunos : Connection
    {
        public List<Alunos> Listar()
        {
            List<Alunos> alunos = banco.Query<Alunos>("select * from Alunos").ToList();
            return alunos;
        }

        public Alunos Buscar(int id)
        {
            return banco.Query<Alunos>("select * from Alunos where id=@id",
                new { id }).SingleOrDefault();
        }
    }
}
