class Livro
{
    public string titulo;
    public string autor;
    public int paginas;
    public int ano;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {titulo}, Autor: {autor}, Número de Páginas: {paginas}, Ano de publicação: {ano}");
    }
    public bool VerificarTrezentos()
    {
    return(paginas > 300);
    }
}
