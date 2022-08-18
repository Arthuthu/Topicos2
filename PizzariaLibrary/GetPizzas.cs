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
    }
}
