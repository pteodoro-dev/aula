using System;
using BibliotecaApp;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca minhaBiblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Adicionar livro");
            Console.WriteLine("2 - Mostrar livros");
            Console.WriteLine("3 - Mudar status de um livro");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.Write("Nome do livro: ");
                string nome = Console.ReadLine();

                Console.Write("Autor: ");
                string autor = Console.ReadLine();

                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());

                Livro novoLivro = new Livro(nome, autor, ano);
                minhaBiblioteca.AdicionarLivro(novoLivro);
            }
            else if (escolha == "2")
            {
                minhaBiblioteca.MostrarLivros();
            }
            else if (escolha == "3")
            {
                minhaBiblioteca.MostrarLivros();
                Console.Write("`\nNumero do livro para mudar status: ");
                int num = int.Parse(Console.ReadLine()) - 1;
                minhaBiblioteca.MudarStatus(num);
            }
            else if (escolha == "0")
            {
                Console.WriteLine("Saindo.");
                break;
            }
            else
            {
                Console.WriteLine("Opcao invalida.");
            }
        }
    }
}
