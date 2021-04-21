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

		contatos.Inserir(new Pessoa("Filo", "4"));
		Console.WriteLine("Nova altura = 3: {0}",
			contatos.Altura()
		); // a nova altura deve ser 3

		contatos.Remover("Cais"); // desbalanceia
		Console.WriteLine("Nova raiz = Elmo: {0}",
			contatos.Raiz().ID()
		); // a nova raiz deve ser Elmo
		
		Console.WriteLine("Nova altura = 2: {0}",
			contatos.Altura()
		); // a nova altura deve ser 2

	} // fim da Main


} // fim da classe Principal
