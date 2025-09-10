

using System.ComponentModel.Design;

namespace Biblioteca.Classes;

public class Livro
{
    public string nome { get; set; }
    public string autor { get; set; }
    public int ano { get; set; }


    public Livro(string NomeTitulo, string Autor, int Ano)
    {
        nome = NomeTitulo;
        autor = Autor;
        ano = Ano;
    }
    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($@"
     =====================
     Nome: {nome} 
     Autor: {autor}
     Ano: {ano}");
    }


    public void Status(int statuverificar)
    {
        if (statuverificar >= 0) 
        {
            status = statuverificar;
            Console.WriteLine("\nStatus verificado com sucesso!");





        }
    }
}
    


