using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using gabriel_almeida.Models;

namespace gabriel_almeida.Models
{
    public class Pagamento
    {
        [Key]
        public int id {get;set;}
        public DateOnly dataLimite {get;set;}
        public double valor {get;set;}
        public bool pago {get; set;}
        
    }
}