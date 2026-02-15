namespace Walking;

internal class Cenario
{
    public string Chao { get; set; }
    public byte Tamanho { get; set; }

    public Cenario(string chao, byte tamanho)
    {
        this.Chao = chao;
        this.Tamanho = tamanho;
    }

    public void imprime(Player p)
    {
        Console.Clear();
        Console.WriteLine();

        //Imprime a primeira linha
        if(p.Pulando)
        {
            for (byte i = 0; i < p.Posicao; i++)
            {
               Console.Write(" ");
            }
            Console.WriteLine(p.Aparencia);
        }
        else
        {
            Console.WriteLine();
        }

        //Imprime a segunda linha
        for (byte i = 0; i < p.Posicao; i++)
        {
            Console.Write(Chao);
        }

        if (p.Pulando) Console.Write(Chao);
        else Console.Write(p.Aparencia);

        for (byte i = 0; i < (Tamanho - p.Posicao); i++)
        {
            Console.Write(Chao);
        }

    }
}
