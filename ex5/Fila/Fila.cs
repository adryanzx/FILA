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

    public void inserirEnfileirar(int Valor){
        
        //CRIAR NOVO NO
        No novoNo = new(Valor);

        if(this.estaVazia() == true){ //FILA VAZIA!
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            novoNo.prox = this.inicio; //O prox do fim (que era nulo) passa a apontar para o novo no
            this.inicio = novoNo; //Fim passa a ser o novo no
        }
    }

public void removerDesenfileirar() {
    if (this.estaVazia()) {
        return;
    } else if (this.inicio == this.fim) { // Caso exista apenas um elemento na Fila
        this.inicio = null;
        this.fim = null;
    } else {
        No noAnterior = null;
        No noAtual = this.inicio;

        while (noAtual.prox != null) {
            noAnterior = noAtual;
            noAtual = noAtual.prox;
        }

        // Agora noAtual aponta para o último nó
        noAnterior.prox = null; // Remove o último nó da fila
        this.fim = noAnterior; // Atualiza o fim da fila
    }
}

    public Boolean consulta(int valor, ref No noAtual, ref No noAnterior){

        noAtual = this.inicio;
        noAnterior = null;

        while(noAtual != null){
            
            if(noAtual.valor == valor){
                return(true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.prox;
        }
        return(false);
    }

    public int contar() {
        No noAtual = this.inicio;
        int contagem = 0;

        while (noAtual != null) {
            contagem = contagem + 1;
            noAtual = noAtual.prox;
    }
    return contagem;
    
}


    public void imprimir(){

        No noAux = this.inicio;
        
        Console.WriteLine("Elementos: ");
        
        while(noAux != null){
            Console.WriteLine(noAux.valor + " -> ");
            noAux = noAux.prox;
        }
    }

}