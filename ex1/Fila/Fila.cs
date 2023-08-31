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
            this.fim.prox = novoNo; //O prox do fim (que era nulo) passa a apontar para o novo no
            this.fim = novoNo; //Fim passa a ser o novo no
        }
    }

    public void removerDesenfileirar(){
        if(this.estaVazia() == true){
            return;
        }
        else if(this.inicio == this.fim){ //Caso exista apenas um elemento na Fila
            this.inicio = null;
            this.fim = null;
        }
        else{ //Remoção do elemento no inicio da Fila
            this.inicio = this.inicio.prox;
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

    public void imprimir(){

        No noAux = this.inicio;
        
        Console.WriteLine("Elementos: ");
        
        while(noAux != null){
            Console.WriteLine(noAux.valor + " -> ");
            noAux = noAux.prox;
        }
    }

}