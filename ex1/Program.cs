using System;

namespace FilaFIFO{

    class Program{
        static void Main(string[] args){

            Fila fila = new();

            //Inserção
            fila.inserirEnfileirar(12);
            fila.inserirEnfileirar(7);
            fila.inserirEnfileirar(10);
            
            //Percurso = Impressão
            fila.imprimir();

            //Consulta
            No noAtual = null;
            No noAnterior = null;
            fila.consulta(7, ref noAtual, ref noAnterior);

            //Remoção
            fila.removerDesenfileirar();
            fila.removerDesenfileirar();
            fila.removerDesenfileirar();
            fila.imprimir();
        }
    }
}
