
using System.Reflection.Metadata;

namespace Biblioteca.Classes;

public class Biblioteca
{
    public List<Livro> livros {  get; set; }
    public int titulo { get; set; }


    public Biblioteca(int Titulo)
    {
        titulo = Titulo;
        {
            new Livro("Harry Potter", "J. K. Rowling", 1998, true);
            new Livro("Frankstain", "Mary Shelley", 1818, true);

        }
    }
}


