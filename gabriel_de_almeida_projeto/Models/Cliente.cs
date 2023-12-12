using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gabriel_almeida.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set;}
        public string? nome { get;set;}
        public int codNotaDeVenda { get;set;}
    }
}