using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFinais.Models
{
    public class VendaDois
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public decimal? Desconto { get; set; }

        public VendaDois(int id, string produto, decimal preco, decimal? desconto) {

            Id = id;
            Produto = produto;
            Preco = preco;
            Desconto = desconto;

        }
    }
}