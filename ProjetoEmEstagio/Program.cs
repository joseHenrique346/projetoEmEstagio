string[,] jogo;
jogo = new string[11, 24];

int pontos = 0;
CriacaoMatriz("O");
ValorDiferente(jogo);
ExibirJogo(jogo);

int linha;
int coluna;

Console.WriteLine("\n[Insira a linha e a coluna separados por ',']");
Console.Write("Seu palpite: ");
string[] palpite = Console.ReadLine().Split(",");
int linhaPalpite = int.Parse(palpite[0])-1;
int colunaPalpite = int.Parse(palpite[1])-1;

if (linhaPalpite == linha && colunaPalpite == coluna)
{
    Console.WriteLine("Certou!");
    Pontuacao(pontos);
}
else { Falha("> Jogo Encerrado <");
    Perdeu(pontos);
}


void CriacaoMatriz(string variavel)
{
    for (int i = 0; i < 11; i++)
    {
        for (int j = 0; j < 11; j++)
        {
            jogo[i, j] = variavel;
        }
    }
}


string[,] ValorDiferente(string[,] jogo)
{
    Random rnd = new Random();
    linha = rnd.Next(10);
    coluna = rnd.Next(10);
    jogo[linha, coluna] = "0";
    //Console.WriteLine((linha +1 ) + " " + (coluna + 1));
    return jogo;
}

static void ExibirJogo(string[,] jogo)
{
    int cont = 1;
    Console.Write("    ");
    for (int h = 1; h <= 10; h++)
    {
        Console.Write(h + " ");
    }
    Console.WriteLine("\n");
    for (int i = 0; i < 10; i++)
    {
        if (cont != 10)
        {
            Console.Write(cont + "   ");
        }
        else
        {
            Console.Write(cont + "  ");
        }
        for (int j = 0; j < 10; j++)
        {
            Console.Write(jogo[i, j]);
            Console.Write(" ");
        }
        cont++;
        Console.WriteLine();
    }
}

static void Falha(string txt)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(txt);
    Console.ResetColor();
}

void Pontuacao(int pontos)
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(250);
        pontos ++;
        Console.Clear();
        Console.WriteLine("==============");
        Console.WriteLine(" PONTUAÇÃO: " + pontos);
        Console.WriteLine("==============");

    }
    Console.ResetColor ();
};

void Perdeu(int pontos)
{
    Console.ForegroundColor = ConsoleColor.Red;
    if (pontos > 10)
    {
        for (int i = 0; pontos > 10; i += 10)
        {
            Thread.Sleep(250);
            pontos-=10;
            Console.Clear();
            Console.WriteLine("==============");
            Console.WriteLine(" PONTUAÇÃO: " + pontos);
            Console.WriteLine("==============");
        }
    }
    Thread.Sleep(1500);
    Console.Clear ();
    Console.WriteLine("==============");
    Console.WriteLine(" PONTUAÇÃO: " + pontos);
    Console.WriteLine("==============");
    for (int i = 0; pontos > 0; i++)
    {
        Thread.Sleep(250);
        pontos--;
        Console.Clear();
        Console.WriteLine("==============");
        Console.WriteLine(" PONTUAÇÃO: " + pontos);
        Console.WriteLine("==============");

    }
    Console.ResetColor();
}

