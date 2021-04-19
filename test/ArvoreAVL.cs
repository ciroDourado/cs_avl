using System;
using System.Collections.Generic;

class ArvoreAVL {
	// atributos
	private ArvoreBinaria arvore;



	// métodos abertos
	public ArvoreAVL() {
		this.arvore = new ArvoreBinaria();
	} // fim construtor padrão


	public bool EstaVazia() {
		return this.arvore.EstaVazia();
	} // fim EstaVazia


	public void Inserir( Tabela dados ) {
		this.arvore.Inserir(dados);
		if( this.EstaDesbalanceada()) this.Ordenar();
	} // fim do método Inserir


	public int Contar() {
		return this.arvore.Contar();
	} // fim Contar


	public NoArvore Buscar( string elemento ) {
		return this.arvore.Buscar(elemento);
	} // fim Buscar


	public NoArvore Raiz() {
		return this.arvore.Raiz();
	} // fim do método (get/Obter) Raiz


	public int Altura() {
		return this.arvore.EstaVazia()?
			0:
			this.Raiz().Altura();
	} // fim do método (get/Obter) Raiz





	// métodos fechados
	private bool EstaDesbalanceada() {
		return (this.NosDesbalanceados()).Count != 0;
	} // fim do método EstaDesbalanceada


	private Stack<NoArvore> NosDesbalanceados() {
		var nos = this.TodosOsNos();
		var nosDesbalanceados = new Stack<NoArvore>();

		foreach(NoArvore no in nos) {
			if( no.DiferencaAlturaFilhos() > 1 )
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
		Stack<NoArvore> nos = NosDesbalanceados();

		while( nos.Count != 0 ) {
			var noAtual = nos.Pop();
			this.Rotacionar(noAtual);
		}
		return;
	} // fim do método Ordenar

	
	private void Rotacionar( NoArvore no ) {
		no.AlturaEsquerda() > no.AlturaDireita()?
			this.RotacionarParaEsquerda(no):
			this.RotacionarParaDireita (no);
	} // fim do método Rotacionar


	private void RotacionarParaEsquerda( NoArvore no ) {

	} // fim do método RotacionarParaEsquerda


	private void RotacionarParaDireita( NoArvore no ) {

	} // fim do método RotacionarParaDireita


} // fim da classe ArvoreAVL
