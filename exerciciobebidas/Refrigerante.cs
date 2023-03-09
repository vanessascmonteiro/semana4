using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciobebidas
{
    public class Refrigerante : Bebida
    {
        public bool Vidro { get; set;}

        public void ImprimirRefrigerante(){
            if(Vidro == true)
            {
                Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante Milimitros {Milimitro} é um vidro ");
            } 
            else
            {
                Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante Milimitros {Milimitro} é uma garrafa pet");

            }
        }
        
    }
}