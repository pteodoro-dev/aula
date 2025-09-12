public class Batalha
{
    private Personagem heroi;
    private Monstro monstro;

    public void IniciarBatalha(Personagem heroi, Monstro monstro)
    {
        this.heroi = heroi;
        this.monstro = monstro;

        Console.WriteLine("\nA batalha começou!");

        while (heroi.EstaVivo && monstro.EstaVivo)
        {
            Console.WriteLine("\nSeu turno! Escolha uma ação:");
            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Curar");
            Console.Write("Opção: ");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                heroi.Atacar(monstro);
            }
            else if (escolha == "2")
            {
                heroi.Curar();
            }
            else
            {
                Console.WriteLine("Opção inválida. Você perdeu o turno!");
            }

            if (!monstro.EstaVivo) break;

            Console.WriteLine("\nTurno do monstro!");
            monstro.Atacar(heroi);
        }

        Console.WriteLine("\n Fim da batalha!");
        if (heroi.EstaVivo)
            Console.WriteLine($"Você venceu! {heroi.Nome} sobreviveu com {heroi.PontosDeVida} de vida.");
        else
            Console.WriteLine($"Você foi derrotado... O monstro {monstro.Nome} venceu.");
    }
}
