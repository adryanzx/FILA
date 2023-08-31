using System;

namespace FilaFIFO{

    class Program{
        static void Main(string[] args){

            Fila fila = new Fila();

            Cliente cliente1 = new Cliente { nome = "Adryan", idade = 18, valorPagoIngresso = 20.0, pagouMeia = false };
            Cliente cliente2 = new Cliente { nome = "Lucas", idade = 11, valorPagoIngresso = 10.0, pagouMeia = true };

            //Inserção
            fila.inserirEnfileirar(cliente1);
            fila.inserirEnfileirar(cliente2);
            
            //Percurso = Impressão
            fila.imprimir();

            //Consulta
            string nomeConsulta = "Lucas";
            No noAtual = null;
            No noAnterior = null;

            // Realizar a consulta
            bool encontrado = fila.consulta(nomeConsulta, ref noAtual, ref noAnterior);

            if (encontrado) {
                Console.WriteLine($"Cliente {nomeConsulta} encontrado na fila!");
            } else {
                Console.WriteLine($"Cliente {nomeConsulta} não encontrado na fila.");
            }

            //Remoção
            fila.removerDesinfilerar();
            fila.imprimir();


        }
    }
}
