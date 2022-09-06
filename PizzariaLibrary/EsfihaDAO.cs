using Dapper;
using PizzariaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaLibrary
{
    public class EsfihaDAO : Conexao
    {
        public List<Esfihas> Listar()
        {
            List<Esfihas> esfihas = banco.Query<Esfihas>("select * from Esfihas").ToList();
            return esfihas;
        }

        public Esfihas Buscar(int id)
        {
            return banco.Query<Esfihas>("select * from Esfihas where id=@id",
                new { id }).SingleOrDefault();
        }
    }
}
