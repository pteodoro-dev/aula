using estoque.classes;

vestuario camisaNike = new vestuario ("Camisa da Nike", 199.99, 100, "83941A", "esportiva", "branca", "G");

eletronico NotebookG15 = new eletronico("DELL G15", 3500.00, 50, "23485B", "110V", true);

GerenciadordeEstoque estoque1 = new GerenciadordeEstoque(1, "Estoque 1");

int escolhaUsuario;


do


Console.WriteLine($@"
======================
Sistema de Controle de Estoque

1 - Cadastrar um produto
2 - Listar Produtos
0 - Sair
---------------------
>");
   try
   { 
    escolhaUsuario = int.Parse(Console.ReadLine());
   }
   catch (Exception)
   {
    case 
   }
