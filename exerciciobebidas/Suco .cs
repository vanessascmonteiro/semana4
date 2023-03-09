using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exerciciobebidas;

namespace exerciciobebidas
{
    public class Suco : Bebida
    {
        public string TipoCaixa { get; set; }

        

        public void ImprimirSuco(){
            Console.WriteLine($"O produto id {Id} é um suco é do tipo {TipoCaixa} com quantidade de Militros {Milimitro}");

        }
    }
}