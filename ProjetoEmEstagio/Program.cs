
string[,] jogo;
jogo = new string[11, 24];



void CriacaoMatriz(string variavel)
{
    for (int i = 0; i < 11; i++)
    {
        for (int j = 0; j < 24; j++)
        {
            jogo[i, j] = variavel;
        }
    }
}

CriacaoMatriz("O");
ValorDiferente(jogo);
ExibirJogo(jogo);

int linha;
int coluna;

string[] palpite = Console.ReadLine().Split(",");
int linhaPalpite = int.Parse(palpite[0]);
int colunaPalpite = int.Parse(palpite[1]);

if (linhaPalpite == linha && colunaPalpite == coluna)
{
    Console.WriteLine("Certou!");
}
else { Falha("Errou"); }

string[,] ValorDiferente(string[,] jogo)
{
    Random rnd = new Random();
    linha = rnd.Next(10);
    coluna = rnd.Next(24);
    jogo[linha, coluna] = "0";
    Console.WriteLine(linha + " " + coluna);
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

static void Falha(string txt)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(txt);
    Console.ResetColor();
}