using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using gabriel_almeida.Models;

namespace gabriel_almeida.Models
{
    public class Marca
    {
        [Key]
        public int id {get;set;}
        public string? nome { get;set;}
        public string? descricao { get;set;}   
    }
}