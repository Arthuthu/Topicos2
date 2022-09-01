using Dapper;
using PizzariaLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzariaLibrary
{
    public class GetPizzas : Conexao
    {
        public List<Pizzas> Listar()
        {
            List<Pizzas> pizzas = banco.Query<Pizzas>("select * from Pizzas").ToList();
            return pizzas;
        }

        public Pizzas Buscar(int id)
        {
            return banco.Query<Pizzas>("select * from Pizzas where id=@id",
                new { id }).SingleOrDefault();
        }

        public Pizzas Criar(int idTipo, string nome, string descricao, int quantidade, decimal valor, bool ativo)
        {
            return banco.Query<Pizzas>($"insert into Pizzas where {idTipo} = @IdTipo, {nome} = @Nome" +
                $", {descricao} = @Descricao, {quantidade} = @Quantidade, {valor} = @Valor, {ativo} = @Ativo ").SingleOrDefault();
        }
    }
}
