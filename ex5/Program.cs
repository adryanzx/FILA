using System;

namespace FilaFIFO{

    class Program{
        static void Main(string[] args){

            Fila fila1 = new();

            //Inserção
            fila1.inserirEnfileirar(12);
            fila1.inserirEnfileirar(7);
            fila1.inserirEnfileirar(10);
            
            //Percurso = Impressão
            fila1.imprimir();

            //Remoção


            //fila 2
            Fila fila2 = new();

            //Inserção
            fila2.inserirEnfileirar(18);
            fila2.inserirEnfileirar(17);
            fila2.inserirEnfileirar(16);
            fila2.inserirEnfileirar(15);


            fila2.imprimir();
            fila2.contar();

            int quantidade1 = fila1.contar();
            Console.WriteLine($"Quantidade de elementos na fila 1: {quantidade1}");

            int quantidade2 = fila2.contar();
            Console.WriteLine($"Quantidade de elementos na fila 2: {quantidade2}");


            static void compara(Fila fila1, Fila fila2)
            {
                int qtd1 = fila1.contar();
                int qtd2 = fila2.contar();
                
                if(qtd1 > qtd2){
                    Console.WriteLine("A fila numero 1 contem mais elementos");
                }
                else
                    Console.WriteLine("A fila numero 2 contem mais elementos");
                   
            }

            compara(fila1, fila2);




        }
    }
}
