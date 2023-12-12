using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gabriel_almeida.Models
{
    public class Produto 
    {
       [Key]
       public int id { get;set;}
       public string? nome {get; set;}
       public string? descricao { get; set;}
       public int quantidade { get;set;}
       public double preco { get;set;}
       public int idDoItem { get;set;}
       public int idDaMarca { get;set;}

    }
}