namespace Walking;

internal class Player
{
    public byte Posicao { get; set; }
    public string Aparencia { get; set; }
    public string FacinRight { get; set; }
    public string FacinLeft { get; set; }
    public bool Pulando { get; set; }

    public Player(string right, string left)
    {
        Posicao = 0;
        Aparencia = right;
        FacinRight = left;
        FacinLeft = FacinRight;
        Pulando = false;
    }

    public void pula()
    {
        Console.Beep(234, 100);
    }

    public void anda(bool direcao, byte limite)
    {
       if(direcao)
       {
           Posicao++;
           Aparencia = FacinRight;
       }
       else
       {
            if(Posicao > 0)
            {
                Posicao--;
                Aparencia = FacinLeft;
            }
        }
    }
}
