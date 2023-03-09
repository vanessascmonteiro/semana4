using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exerciciobebidas;

namespace exerciciobebidas
{
    public static class Repositório 
    {
        public static List<Bebida> ListaBebida { get; set; }
        public static List<Suco> ListaSuco { get; set; }
        public static List<Refrigerante> ListaRefrigerante { get; set;}

        static Repositório()
        {
            if(ListaBebida == null)
            {
                ListaBebida = new List<Bebida>();
            }
            if(ListaSuco == null)
            {
                ListaSuco = new List<Suco>();
            }
            if(ListaRefrigerante == null)
            {
                ListaRefrigerante = new List<Refrigerante>();
            }

        }
        
    
    public static void AdicionarSuco(Suco suco)
    {
       ListaSuco.Add(suco);
    }
    public static void AdicionarRefrigerante(Refrigerante refrigerante)
    {
        ListaRefrigerante.Add(refrigerante);
    }
    public static void AdicionarBebiba(Bebida bebida)
    {
        ListaBebida.Add(bebida);
    }

    
    public static void AlterarBebida(Bebida bebida)

    {
        foreach(var item in ListaBebida.Where(listaEmMemoria => listaEmMemoria.Id == bebida.Id))
        {
            item.NomeBebida = bebida.NomeBebida;
        }
      }
       public static void ExcluirBebida( int id)
       {
          var localBebiba = ListaBebida.FirstOrDefault(w => w.Id == id);
          if(localBebiba != null)
          {
            ListaBebida.Remove(localBebiba);
          }
       }
       public static List<Bebida> ListarBebibas()
       {
          return ListaBebida;
       }  
       public static void ImprimirSuco()
       {
        foreach (var suco in ListaSuco)
        suco.ImprimirSuco();

       }
       public static void ImprimirRefrigerante()
       {
        foreach(var refrigerante in ListaRefrigerante)
           refrigerante.ImprimirRefrigerante();
       }

     

     
     
       
     }  

    }

