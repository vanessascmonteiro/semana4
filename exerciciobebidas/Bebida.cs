using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciobebidas
{
    public class Bebida
        {
           
        public int Id {get; set; }
        public string Refrigerante { get; set; }

        public string Suco { get; set; }
        public decimal Milimitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }

        public void Comprar(decimal ValorCompra){
            //ValorCompra = novo.ValorCompra;
            Console.WriteLine($"Valor da compra do produto id{Id} alterado para {ValorCompra} ");

        


        }
        
    
    }
}