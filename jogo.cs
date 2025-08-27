Console.WriteLine("Bem vindo ao jogo");
Console.WriteLine("digite um numero de 1 a 100");

Random random = new Random();
int numeroSecreto = random.Next(1, 101);
int palpite = 0;

while (palpite != numeroSecreto)
{
    Console.WriteLine("digite seu palpite");
    palpite = int.Parse(Console.ReadLine());

    if (palpite < numeroSecreto)
    {
        Console.WriteLine("numero secreto e maior, tente novamente");
    }
    else if (palpite > numeroSecreto)
    {
        Console.WriteLine("o numero secreto e menor, tente novamente");
    }
    else
    {
        Console.WriteLine("parabens voce ganhou o jogo!");
    }
}


            

