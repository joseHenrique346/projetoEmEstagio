CriacaoMatriz("O");

static void Falha(string txt)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(txt);
    Console.ResetColor();
}

static void CriacaoMatriz<T>(T variavel)
{
    T[,] jogo = new T[11, 24];
    for (int i = 0; i < 11; i++)
    {
        for (int j = 0; j < 24; j++)
        {
            jogo[i, j] = variavel;
        }
    }
}

static string[,] ValorDiferente(string[,] jogo)
{
    Random rnd = new Random();
    int linha = rnd.Next(10);
    int coluna = rnd.Next(24);
    jogo[linha, coluna] = "0";
    return jogo;
}

static void ExibirJogo(string[,] jogo)
{
    for (int i = 0; i < 11; i++)
    {
        for (int j = 0; j < 24; j++)
        {
            Console.Write(jogo[i, j]);
        }
        Console.WriteLine();
    }
}