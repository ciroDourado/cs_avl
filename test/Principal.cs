using System;

class Principal {


	static void Main() {
		var contatos = new ArvoreAVL();

		contatos.Inserir(new Pessoa("Cais", "1"));
		Console.WriteLine("{0}",
			contatos.Raiz().ID()
		); // a raiz inicialmente é Cais

		contatos.Inserir(new Pessoa("Deno", "2"));
		contatos.Inserir(new Pessoa("Elmo", "3"));
		Console.WriteLine("{0}",
			contatos.Raiz().ID()
		); // a nova raiz deve ser Deno

	} // fim da Main


} // fim da classe Principal
