using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaLibrary.Models
{
    public class Pizzas
    {
        public int Id { get; set; }
        [DisplayName("Tipo")]
        public int IdTipo { get; set; }
        public string Nome { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        //Campos virtuais
        [DisplayName("Tipo")]
        public string TipoNome { get; set; }
    }
}
