using exerciciobebidas;

Bebida bebida1 = new Bebida();

Repositório.AdicionarBebiba(bebida1);

Repositório.AlterarBebida(bebida1);

var listaAntesExluir = Repositório.ListarBebibas();

Suco suco1 = new Suco();

Refrigerante refrigerante1 = new Refrigerante();

Repositório.ExcluirBebida(1);
var listaAposExcluir = Repositório.ListarBebibas();

Repositório.AdicionarSuco(suco1);
Repositório.AdicionarRefrigerante(refrigerante1);



