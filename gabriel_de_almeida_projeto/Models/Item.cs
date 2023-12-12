using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using gabriel_almeida.Models;




namespace gabriel_almeida.Models
{
    public class Item
    { 
        [Key]
        public int id { get;set;}
        public double preco { get;set;}
        
        public int percentual { get;set;}
        public string? quantidade { get;set;}
        public int idProduto { get;set;}

    }
}