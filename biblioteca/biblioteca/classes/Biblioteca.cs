using System;
using System.Collections.Generic;

namespace BibliotecaApp
{
    public class Biblioteca
    {
        public List<Livro> Livros { get; set; }

        public Biblioteca()
        {
            Livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
            Console.WriteLine("Livro adicionado com sucesso!");
        }

        public void MostrarLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }

            for (int i = 0; i < Livros.Count; i++)
            {
                Console.Write($"{i + 1} - ");
                Livros[i].Mostrar();
            }
        }

        public void MudarStatus(int indice)
        {
            if (indice >= 0 && indice < Livros.Count)
            {
                Livros[indice].Disponivel = !Livros[indice].Disponivel;
                Console.WriteLine("Status alterado");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
    }
}
