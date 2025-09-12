public class Personagem : Entidade
{
    public string Classe { get; set; }

    public void Curar()
    {
        int cura = 20;
        PontosDeVida += cura;
        Console.WriteLine($"{Nome} se curou em {cura} pontos. Vida atual: {PontosDeVida}");
    }
}
