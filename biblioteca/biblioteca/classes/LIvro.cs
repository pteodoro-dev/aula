using System;

namespace BibliotecaApp
{
    public class Livro
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public bool Disponivel { get; set; }

        public Livro(string nome, string autor, int ano)
        {
            Nome = nome;
            Autor = autor;
            Ano = ano;
            Disponivel = true;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Título: {Nome}, Autor: {Autor}, Ano: {Ano}, Status: {(Disponivel ? "Disponível" : "Indisponível")}");
        }
    }
}
