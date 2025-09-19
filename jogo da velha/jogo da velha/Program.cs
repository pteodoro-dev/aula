using System;
using jogo_da_velha;

class Program
{
    static void Main()
    {
        string jogarNovamente;

        do
        {
            Tabuleiro tabuleiro = new Tabuleiro();
            Console.WriteLine("Digite o nome do Jogador 1 (X):");
            string nomeJogador1 = Console.ReadLine();
            Jogador jogador1 = new Jogador(nomeJogador1, 'X');

            Console.WriteLine("Digite o nome do Jogador 2 (O):");
            string nomeJogador2 = Console.ReadLine();
            Jogador jogador2 = new Jogador(nomeJogador2, 'O');

            Jogador jogadorAtual = jogador1;
            bool jogoTerminou = false;

            int vitoriasJogador1 = 0;
            int vitoriasJogador2 = 0;

            while (!jogoTerminou)
            {
                tabuleiro.Desenhar();

                Console.WriteLine($"\n{jogador1.Nome} (X): {vitoriasJogador1} vitórias");
                Console.WriteLine($"{jogador2.Nome} (O): {vitoriasJogador2} vitórias");

                Console.WriteLine($"\n{jogadorAtual.Nome}, é a sua vez. Escolha uma posição (1-9):");
                int posicao = int.Parse(Console.ReadLine());

                if (tabuleiro.MarcarJogada(posicao, jogadorAtual.Simbolo))
                {
                    if (tabuleiro.VerificarVencedor(jogadorAtual.Simbolo))
                    {
                        tabuleiro.Desenhar();
                        Console.WriteLine($"\nParabéns {jogadorAtual.Nome} venceu!");

                        if (jogadorAtual == jogador1)
                            vitoriasJogador1++;
                        else
                            vitoriasJogador2++;

                        jogoTerminou = true;
                    }
                    else if (tabuleiro.VerificarEmpate())
                    {
                        tabuleiro.Desenhar();
                        Console.WriteLine("\nO jogo terminou em empate!");
                        jogoTerminou = true;
                    }
                    else
                    {
                        jogadorAtual = jogadorAtual == jogador1 ? jogador2 : jogador1;
                    }
                }
                else
                {
                    Console.WriteLine("Jogada inválida! Pressione Enter para tentar novamente");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("\nDesejam jogar novamente? (S/N):");
            jogarNovamente = Console.ReadLine().ToUpper();

        } while (jogarNovamente == "S");

        Console.WriteLine("Obrigado por jogar!");
    }
}
