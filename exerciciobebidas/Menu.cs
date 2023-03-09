using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exerciciobebidas;


namespace exerciciobebidas
{
    public static class Menu 
       {
        
        //public List <Bebida> ListaBebida {get; set;}
        public static void DisplayInicial()
        {
            Console.Clear(); //Método que vai limpar os dados em tela
            Console.WriteLine("\n"); //Quebra de linha com o \n e WriteLine
            Console.WriteLine("Loja de Bebidas:"); //Titulo do console
            Console.WriteLine("*******************************************************"); //Corte da linha
            Console.WriteLine("\n"); //Quebra de linha com o \n e WriteLine
        }

        /// <summary>
        /// Função que vai retornar o valor digitado da tela
        /// </summary>
        /// <returns>Inteiro</returns>
        public static int DigiteOpcaoDesejada()
        {

            try //Bloco do código certo
            {
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1- Inserir Bebiba");
                Console.WriteLine("2- Alterar Bebiba");
                Console.WriteLine("3- Excluir Bebiba");
                Console.WriteLine("4- Listar todas as Bebibas");
                Console.WriteLine("5- Listar todos os Sucos");
                Console.WriteLine("6- Listar todos os refrigerantes");
                Console.WriteLine("7- Sair");
                Console.WriteLine("\n");
                
                Console.WriteLine("Opção :");
                return Convert.ToInt32(Console.ReadLine());
                            
            }

            catch (Exception ex)
            {
                Console.WriteLine("Opção com erro, selecione a opção correta");

            }
            return DigiteOpcaoDesejada();
            
            
            }
    
             public static bool ReiniciarDisplayConsole()
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Deseja reiniciar o menu: ");
            Console.WriteLine("1 - Sim.");
            Console.WriteLine("2 - Não.");
            Console.WriteLine("\n");

            Console.WriteLine("Opção :");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Menu.DisplayInicial();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

    
