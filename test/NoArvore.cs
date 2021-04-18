using System;
using System.Collections.Generic;

class NoArvore {
	// atributos
	private NoArvore esquerda;
	private NoArvore direita;
	private Tabela   dados;


	// metodos padrao para atributo Esquerda
	public NoArvore Esquerda() {
		return this.esquerda;
	} // fim (get/Obter) esquerda

	public void Esquerda(NoArvore esquerda) {
		this.esquerda = esquerda;
	} // fim (set/Atribui) esquerda

	public bool HaEsquerda() {
		return this.esquerda != null;
	} // fim try/Ha Esquerda



	// metodos padrao para atributo Direita
	public NoArvore Direita() {
		return this.direita;
	} // fim (get/Obter) direita

	public void Direita(NoArvore direita) {
		this.direita = direita;
	} // fim (set/Atribui) direita

	public bool HaDireita() {
		return this.direita != null;
	} // fim try/Ha Direita



	// metodos padrao para atributo Dados
	public Tabela Dados() {
		return this.dados;
	} // fim (get/Obter) dados

	public string ID() {
		return (this.dados).IdParaBusca();
	} // fim (get/Obter) id



	// metodos abertos
	public NoArvore(Tabela dados) {
		this.esquerda = null;
		this.direita  = null;
		this.dados    = dados;
	} // fim construtor padrao

	public
	NoArvore AssumeQualRamoDo(NoArvore pai) {
		return pai.Comparar(this) < 0?
			pai.esquerda:
			pai.direita;
	} // fim AssumeQualRamoDo

	public
	int Comparar(NoArvore no) {
		string pai = this.ID();
		string filho = no.ID();

		return String.Compare(pai, filho);
	} // fim Comparar

	public
	NoArvore Proximo( string id ) {
		var idPai = this.ID();
		return String.Compare(idPai, id) < 0?
			this.esquerda:
			this.direita;
	} // fim Proximo

	public
	NoArvore Proximo( NoArvore no ) {
		return this.Proximo(no.ID());
	} // fim Proximo

	public
	int TemQuantosFilhos() {
		var esquerda = Convert.ToInt32(this.HaEsquerda());
		var direita  = Convert.ToInt32(this.HaDireita() );
		return esquerda + direita;
	}  // fim TemQuantosFilhos

	public
	NoArvore NoAnterior() {
		var noAtual = this.esquerda;
		while( noAtual.HaDireita() )
			noAtual = noAtual.direita;
		return noAtual;
	} // fim NoAnterior

	public
	int Altura() {
		var nos = new Queue<NoArvore>();
			nos.Enqueue(this);
		var altura = 0;

		while( nos.Count > 0 ) {
			altura++;
			this.DescerDeNivel(nos);
		}
		return altura;
	} // fim Altura

	public
	int DiferencaAlturaFilhos() {
		var filhoEsquerdo = this.AlturaEsquerda();
		var filhoDireito  = this.AlturaDireita ();
		return Math.Abs(filhoEsquerdo - filhoDireito);
	} // fim DiferencaAlturaFilhos



	// métodos fechados
	private
	int AlturaEsquerda() {
		return this.HaEsquerda()?
			this.esquerda.Altura():
			0;
	} // fim AlturaEsquerda

	private
	int AlturaDireita() {
		return this.HaDireita()?
			this.direita.Altura():
			0;
	} // fim AlturaEsquerda

	private
	void DescerDeNivel(Queue<NoArvore> nos) {
		var nosDoNivelAtual = nos.Count;

		while( nosDoNivelAtual > 0 ) {
			var noAtual = nos.Dequeue();
			nosDoNivelAtual--;

			if( noAtual.HaEsquerda() ) nos.Enqueue( noAtual.esquerda);
			if( noAtual.HaDireita () ) nos.Enqueue( noAtual.direita );
		}
	} // fim DescerDeNivel

} // fim classe NoArvore
