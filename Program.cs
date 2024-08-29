Livro l1 = new Livro();
l1.titulo = "clean code";
l1.autor = "Pablo Marçal";
l1.paginas = 362;
l1.ano = 2004;

l1.ExibirInformacoes();
Console.WriteLine($"Esse livro tem mais de trezentas páginas? {l1.VerificarTrezentos()}");
