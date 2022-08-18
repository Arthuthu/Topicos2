using Business.Models;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace Business.Business
{
    public class GetAlunos : Connection
    {
        //Lista todos os alunos da tabela alunos
        public List<Alunos> Listar()
        {
            List<Alunos> alunos = banco.Query<Alunos>("select * from Alunos").ToList();
            return alunos;
        }

        //Busca um aluno pelo seu Id no banco
        public Alunos Buscar(int id)
        {
            return banco.Query<Alunos>("select * from Alunos where id=@id",
                new { id }).SingleOrDefault();
        }
    }
}
