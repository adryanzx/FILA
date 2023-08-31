public class Fila{

    public No inicio;
    public No fim;

    public Fila(){
        this.inicio = null;
        this.fim = null;
    }

    public Boolean estaVazia(){

        if(this.inicio == null){
            return(true);
        }
        return(false);
    }

        public void inserirEnfileirar(Cliente cliente){
        
        //CRIAR NOVO NO
        No novoNo = new No(cliente);

        if(this.estaVazia() == true){ //FILA VAZIA!
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            this.fim.prox = novoNo; //O prox do fim (que era nulo) passa a apontar para o novo no
            this.fim = novoNo; //Fim passa a ser o novo no
        }
    }
public void removerDesinfilerar() {
    if (this.estaVazia()) {
        return;
    } else if (this.inicio == this.fim) { // Caso exista apenas um elemento na Fila
        this.inicio = null;
        this.fim = null;
    } else {
        this.inicio = this.inicio.prox; // Atualiza o início para o próximo nó
    }
}


    public void imprimir() {
        No noAux = this.inicio;

        Console.WriteLine("Elementos: ");

        while (noAux != null) {
            noAux.imprimir(); // Chama o método imprimir do nó para mostrar os detalhes do cliente
            Console.WriteLine("-> ");
            noAux = noAux.prox;
        }
    }

public Boolean consulta(string nome, ref No noAtual, ref No noAnterior) {
    noAtual = this.inicio;
    noAnterior = null;

    while (noAtual != null) {
        if (noAtual.cliente.nome == nome) {
            return true;
        }
        noAnterior = noAtual;
        noAtual = noAtual.prox;
    }
    return false;
}


}