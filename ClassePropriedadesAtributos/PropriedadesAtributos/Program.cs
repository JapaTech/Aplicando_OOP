using PropriedadesAtributos.Banco;
using PropriedadesAtributos.GerenciamentoEstoque;

Console.WriteLine("Exercício Conta Bancária");
Console.WriteLine("------------------------------------\n"); 
Titular andre = new Titular("André da Costa", "R: Brasil, nº 570, B: Jardins", "123456789-0");


Conta contaAndre = new Conta(123456, 7890, "HelloWorld1234", 3500.70, 5000.00, andre);


Console.WriteLine(contaAndre.Titular.Dados);
Console.WriteLine(contaAndre.DadosGerais);

Console.WriteLine("\n******************************\n");

Console.WriteLine("Exercício Estoque"); 
Console.WriteLine("------------------------------------\n");

Produto TV = new Produto();
TV.Nome = "TV LCD Sansung Smart 4k HD Ultra Plus";
TV.Marca = "Samsung";
TV.Quantidade = 5;
TV.Valor = 3999.00;

Produto Notebook = new Produto();
Notebook.Nome = "Notebook Game Asus AMD Ryzen 5 MX56";
Notebook.Marca = "Asus";
Notebook.Quantidade = 10;
Notebook.Valor = 5999.00;
Console.WriteLine("\n******************************");

Estoque estoque = new Estoque();
estoque.AddProduto(TV);
estoque.AddProduto(Notebook);
estoque.ListarProdutos();