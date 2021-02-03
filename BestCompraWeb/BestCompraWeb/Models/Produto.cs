using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BestCompraWeb.Models {
    public class Produto {
        public int ID { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
    }
}
