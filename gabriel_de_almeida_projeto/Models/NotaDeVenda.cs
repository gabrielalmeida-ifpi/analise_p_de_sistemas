using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using gabriel_almeida.Models;

namespace gabriel_almeida.Models
{
    public class NotaDeVenda
    {     
        [Key]
        public int cod { get;set;}
        public string? data { get;set;}
        public bool tipo {get;set;}

        public int idDePagamento {get;set;}
        public int idDoCliente {get;set;}
        public int idDeTransportadora {get;set;}
        public int idTipoDePagamento {get;set;}
 
        public int idDoItem {get;set;}

        public bool cancelar() {
            return true;
            
        }
        public bool devolver(){
            return true;
        }     
    }
}