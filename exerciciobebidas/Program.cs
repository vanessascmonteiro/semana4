using System;
using exerciciobebidas;

Menu.DisplayInicial();

Menu.DigiteOpcaoDesejada();

bool manterMenuAberto = true;

while(manterMenuAberto)
{
    Menu.DisplayInicial();
    var opcao = Menu.DigiteOpcaoDesejada();
    switch(opcao)
    {
        case 1:
        Bebida bebida = new Bebida();
        bebida.Id = 1;
        bebida.Milimitro = 350;
        bebida.NomeBebida = "Cerveja";
        bebida.ValorCompra = 5;
        Repositório.AdicionarBebiba(bebida);
        manterMenuAberto = Menu.ReiniciarDisplayConsole();
        break;

        case 2: 
        Bebida bebida1 = new Bebida();
        bebida1.Id = 2;
        bebida1.Milimitro = 500;
        bebida1.NomeBebida = "Refrigerante";
        bebida1.ValorCompra = 10;
        Repositório.AlterarBebida(bebida1);
        manterMenuAberto = Menu.ReiniciarDisplayConsole();
        break;

        case 3:
        Bebida bebida2 = new Bebida();
        bebida2.Id = 1;
        bebida2.Milimitro = 200;
        bebida2.NomeBebida = "suco";
        bebida2.ValorCompra = 2;
        Repositório.ExcluirBebida(1);
        manterMenuAberto = Menu.ReiniciarDisplayConsole();
        break;

        case 4:
        Repositório.ListarBebibas();
        manterMenuAberto = Menu.ReiniciarDisplayConsole();
        break;

        case 5: 
        Repositório.ImprimirSuco();
        manterMenuAberto = Menu.ReiniciarDisplayConsole();
        break;

        case 6: 
        Repositório.ImprimirRefrigerante();
        manterMenuAberto = Menu.ReiniciarDisplayConsole();
        break;

        case 7:
        Console.WriteLine("Até logo");
        manterMenuAberto = false;
        break;
        default:
        Console.WriteLine("Dados com erros, aguarde o display inicial");
        Thread.Sleep(5000);
        Menu.DisplayInicial();
        break;
    }
}














    






