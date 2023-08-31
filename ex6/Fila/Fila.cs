public class Fila {
    public No inicio;
    public No fim;

    public Fila() {
        this.inicio = null;
        this.fim = null;
    }

    public Boolean estaVazia() {
        return this.inicio == null;
    }

    public void inserirEnfileirar(int Valor) {
        No novoNo = new No(Valor);

        if (this.estaVazia()) {
            this.inicio = novoNo;
            this.fim = novoNo;
        } else {
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public void removerDesenfileirar() {
        if (this.estaVazia()) {
            return;
        } else if (this.inicio == this.fim) {
            this.inicio = null;
            this.fim = null;
        } else {
            this.inicio = this.inicio.prox;
        }
    }

    public void imprimir() {
        No noAux = this.inicio;

        Console.WriteLine("Elementos: ");

        while (noAux != null) {
            Console.WriteLine(noAux.valor + " -> ");
            noAux = noAux.prox;
        }
    }

    public void removerNegativos() {
        No noAnterior = null;
        No noAtual = this.inicio;

        while (noAtual != null) {
            if (noAtual.valor < 0) {
                if (noAnterior == null) {
                    this.inicio = noAtual.prox;
                } else {
                    noAnterior.prox = noAtual.prox;
                }

                if (noAtual == this.fim) {
                    this.fim = noAnterior;
                }
            } else {
                noAnterior = noAtual;
            }

            noAtual = noAtual.prox;
        }
    }
}
