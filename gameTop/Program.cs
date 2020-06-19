using System;
using GameTop.Lib;

namespace gameTop
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new JogoFoda(new Jogador1(), new Jogador2());
           jogo.IniciarJogo();
        }
    }
   

}
