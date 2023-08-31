using System;

namespace FilaFIFO {

    class Program {
        static void Main(string[] args) {

            Fila fila = new Fila();

            // Inserção
            fila.inserirEnfileirar(10);
            fila.inserirEnfileirar(-5);
            fila.inserirEnfileirar(8);
            fila.inserirEnfileirar(-3);
            fila.inserirEnfileirar(15);

            // Impressão antes da remoção
            Console.WriteLine("Antes da remoção:");
            fila.imprimir();

            // Remoção dos números negativos
            fila.removerNegativos();

            // Impressão após a remoção
            Console.WriteLine("Após a remoção:");
            fila.imprimir();
        }
    }
}
