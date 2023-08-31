public class No{
    public Cliente cliente;
    public No prox;

//Cliente de um Cinemaque possui: nome,idade,valorPagoIngresso, pagouMeia(true ou false).
    public No(Cliente cliente) {
        this.cliente = cliente;
        this.prox = null;
    }

    public void imprimir() {
        Console.WriteLine("Nome: " + this.cliente.nome);
        Console.WriteLine("Idade: " + this.cliente.idade);
        Console.WriteLine("Valor Pago: " + this.cliente.valorPagoIngresso);
        Console.WriteLine("Pagou Meia: " + this.cliente.pagouMeia);
    }

}
