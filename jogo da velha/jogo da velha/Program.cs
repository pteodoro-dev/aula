using jogo_da_velha;

Tabuleiro tabuleiro = new Tabuleiro();
Jogador jogador1 = new Jogador("Jogaodr 1", 'X');
Jogador jogador2 = new Jogador("Jogador 2", 'O');
Jogador jogadorAtual = jogador1;

bool jogoTerminou = false;

while (jogoTerminou)
{
    tabuleiro.Desenhar();

    Console.WriteLine($"\n{jogadorAtual Nome}, e a sua vez Escolha uma posicao (1-9)");
    int posicao = int.Parse( Console.ReadLine() );

    
}