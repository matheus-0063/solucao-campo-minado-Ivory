using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!
            Random random = new Random();

            while (campoMinado.JogoStatus == 0)
            {
                Console.WriteLine("\nJogo em aberto, continue procurando as posições que não possuem minas terrestres;");
                var linha = random.Next(1, 10);
                var coluna = random.Next(1, 10);

                campoMinado.Abrir(linha, coluna);
                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Abrindo CAMPO: Linha({linha})\tColuna({coluna})\n");
                Console.WriteLine(campoMinado.Tabuleiro);
            }

            if (campoMinado.JogoStatus == 2)
            {
                Console.WriteLine("\nGame Over, você encontrou uma mina terrestre.");
            }
            if (campoMinado.JogoStatus == 1)
            {
                Console.WriteLine("\nVitoria, você encontrou todas as posições que não possuem minas terrestres.");
            }
            Console.ReadKey();





            //Usuario escolhendo qual casa abrir
            /*
            while (campoMinado.JogoStatus == 0)
            {
                Console.WriteLine("\nJogo em aberto, continue procurando as posições que não possuem minas terrestres;");
                Console.Write("\nQual linha deseja abrir: ");
                int linha = int.Parse(Console.ReadLine());
                Console.Write("Qual coluna deseja abrir: ");
                int coluna = int.Parse(Console.ReadLine());

                campoMinado.Abrir(linha, coluna);
                Console.Clear();
                Console.WriteLine(campoMinado.Tabuleiro);

            }

            if (campoMinado.JogoStatus == 2)
            {
                Console.WriteLine("\nGame Over, você encontrou uma mina terrestre.");
            }
            if (campoMinado.JogoStatus == 1)
            {
                Console.WriteLine("\nVitoria, você encontrou todas as posições que não possuem minas terrestres.");
            }
            Console.ReadKey();
            */
        }
    }
}
