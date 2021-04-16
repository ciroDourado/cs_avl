using System;
using System.Collections.Generic;

class ArvoreAVL {
	// atributos
	private ArvoreBinaria arvore;



	// métodos abertos
	public ArvoreAVL() {
		this.arvore = new ArvoreBinaria();
	} // fim construtor padrão


	public void Inserir( Tabela dados ) {
		this.arvore.Inserir(dados);
		if( this.EstaDesbalanceada()) this.Ordenar();
	} // fim do método Inserir





	// métodos fechados
	private bool EstaDesbalanceada() {
		return (this.NosDesbalanceados()).Count != 0;
	} // fim do método EstaDesbalanceada


	private Stack<NoArvore> NosDesbalanceados() {
		var nos = this.TodosOsNos();
		var nosDesbalanceados = new Stack<NoArvore>();

		foreach(NoArvore no in nos) {
			if( no.DiferencaAlturaEsqDir() > 1 )
				nosDesbalanceados.Push(no);
		}
		return nosDesbalanceados;
	} // fim do método NosDesbalanceados


	private Stack<NoArvore> TodosOsNos() {
		var iterador =  new Stack<NoArvore>();
		    iterador.Push(this.arvore.Raiz());

		var nos = new Stack<NoArvore>();
		var quantidade = this.arvore.Contar();

		while( nos.Count != quantidade ) {
			var no = iterador.Pop();
			nos.Push(no);

			if( no.HaEsquerda() ) iterador.Push(no.Esquerda());
			if( no.HaDireita()  ) iterador.Push(no.Direita() );
		}
		return nos;
	} // fim do método TodosOsNos


	private void Ordenar() {
		return;
	} // fim do método Ordenar


} // fim da classe ArvoreAVL
