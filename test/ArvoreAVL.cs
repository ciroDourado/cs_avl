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
		return (this.NosDesbalanceados()).Count == 0;
	} // fim do método EstaDesbalanceada


	private Stack<NoArvore> NosDesbalanceados() {
		var nos = this.TodosOsNos();

		return new Stack<NoArvore>();
	} // fim do método NosDesbalanceados


	private Stack<NoArvore> TodosOsNos() {
		var iterador =  new Stack<NoArvore>();
		    iterador.Push(this.arvore.Raiz());

		var nos = new Stack<NoArvore>();
		var quantidade = this.arvore.Contar();
		return nos;
	} // fim do método TodosOsNos


	private void Ordenar() {
		return;
	} // fim do método Ordenar


} // fim da classe ArvoreAVL
