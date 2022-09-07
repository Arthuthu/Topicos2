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

        public Esfihas Criar(Esfihas esfihas)
        {
            banco.Execute("insert into Esfihas values (@IdTipo, @Nome, @Descricao, @Valor, @Ativo)", esfihas);
            return esfihas;
        }

        public bool Deletar(int id)
        {
            return banco.Execute("delete from Esfihas where id=@pID",
            new { pID = id }) == 1;
        }

        public void Atualizar(Esfihas esfiha)
        {
            banco.Execute($"update Esfihas set IdTipo = @IdTipo, Nome = @Nome," +
                $" Descricao = @Descricao, Valor = @Valor, " +
                $" Ativo = @Ativo where Id = @Id ", new
                {
                    id = esfiha.Id,
                    IdTipo = esfiha.IdTipo,
                    Nome = esfiha.Nome,
                    Descricao = esfiha.Descricao,
                    Valor = esfiha.Valor,
                    Ativo = esfiha.Ativo
                });
        }
    }
}
