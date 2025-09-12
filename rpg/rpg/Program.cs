class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao RPG de Console!");

        Console.Write("Digite o nome do herói: ");
        string nomeHeroi = Console.ReadLine();
        Console.Write("Digite a classe do herói (ex: Guerreiro): ");
        string classeHeroi = Console.ReadLine();

        Personagem heroi = new Personagem
        {
            Nome = nomeHeroi,
            Classe = classeHeroi,
            PontosDeVida = 100,
            Ataque = 25
        };


        Console.Write("Digite o nome do monstro: ");
        string nomeMonstro = Console.ReadLine();
        Console.Write("Digite o tipo do monstro (ex: Orc): ");
        string tipoMonstro = Console.ReadLine();

        Monstro monstro = new Monstro
        {
            Nome = nomeMonstro,
            Tipo = tipoMonstro,
            PontosDeVida = 80,
            Ataque = 20
        };

        Batalha batalha = new Batalha();
        batalha.IniciarBatalha(heroi, monstro);

        Console.WriteLine("\n Obrigado por jogar!");
    }
}
