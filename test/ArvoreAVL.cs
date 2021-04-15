using System;
using System.Collections;

class ArvoreAVL {
	// atributos
	private ArvoreBinaria arvore;



	// métodos abertos
	public ArvoreAVL() {
		this.arvore = new ArvoreBinaria();
	} // fim construtor padrão

	
	public void Inserir( Tabela dados ) {
		(this.arvore).Inserir(dados);
		if( this.EstaDesbalanceada()) this.Ordenar();
	} // fim do método Inserir
	




	// métodos fechados
	private bool EstaDesbalanceada() {
		return (this.NosDesbalanceados()).Count == 0;
	} // fim do método EstaDesbalanceada


	private void Ordenar() {
		return;
	} // fim do método Ordenar


	private Stack NosDesbalanceados() {
		return new Stack();
	} // fim do método NosDesbalanceados


} // fim da classe ArvoreAVL
