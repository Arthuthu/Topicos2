using Dapper;
using PizzariaLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzariaLibrary
{
    public class PizzaDAO : Conexao
    {
        //Busca todas as Pizzas
        public List<Pizzas> Listar()
        {
            List<Pizzas> pizzas = banco.Query<Pizzas>("select * from Pizzas order by Nome").ToList();
            return pizzas;
        }

        //Busca uma Pizza em especifico por ID
        public Pizzas Buscar(int id)
        {
            return banco.Query<Pizzas>("select * from Pizzas where id=@id",
                new { id }).SingleOrDefault();
        }

        //O objeto que é parametro (pizza), receberá informações da Controller e com essas informações sera feito um Insert no banco
        public Pizzas Criar(Pizzas pizza)         
        {
            banco.Execute("insert into Pizzas values (@IdTipo, @Nome, @Descricao, @Quantidade, @Valor, @Ativo)", pizza);
            return pizza;
        }

        //Deleta uma Pizza em especifico pelo ID
        public bool Deletar(int id)
        {
            return banco.Execute("delete from Pizzas where id=@pID",
            new { pID = id }) == 1;
        }

        //Atualiza as informações da Pizza
        public void Atualizar(Pizzas pizza)
        {
            string sql = @"update Pizzas set IdTipo = @IdTipo, Nome = @Nome,
                        Descricao = @Descricao, Quantidade = @Quantidade, Valor = @Valor,
                        Ativo = @Ativo where Id = @Id";

            using (banco)
            {
                int rowsAffected = banco.Execute(sql, new
                {
                    id = pizza.Id,
                    IdTipo = pizza.IdTipo,
                    Nome = pizza.Nome,
                    Descricao = pizza.Descricao,
                    Quantidade = pizza.Quantidade,
                    Valor = pizza.Valor,
                    Ativo = pizza.Ativo
                });
            }
        }
    }
}
