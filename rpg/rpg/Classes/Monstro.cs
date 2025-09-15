
public class Monstro : Entidade
{
    public string Tipo { get; set; }

    public override void ReceberDano(int dano)
    {
        base.ReceberDano(dano);
        Console.WriteLine($"O monstro {Nome} rugiu de dor! Tipo: {Tipo}");
    }
}
