using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gabriel_almeida.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        public string? numeroDoCartao { get;set;}
        public string? bandeira { get;set;}
    }
}