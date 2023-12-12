using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gabriel_almeida.Models
{
    public class TipoDePagamento
    {
        [Key]
        public int id { get;set;}
        public string? nomeDoCobrado { get; set;}
        public string? informacoesAdicionais { get; set;}

    }
}