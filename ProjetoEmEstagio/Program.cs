Vermei("Menino Fatal");
CriacaoMatriz("O");

static void Vermei(string txt)
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