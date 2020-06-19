using GameTop.Interface;

namespace GameTop.Lib
{
   public class Jogador2:iJogador
    {
        public string Nome { get; set; }

        public Jogador2(string nome  ="Maradona")
        {
            Nome=nome;
            
        }
            public string Chuta()
        {
            return $"{Nome} esta Pateando ";
        }
        public string Corre()
        {
            return $"{Nome} esta  Corriendo";
        }

        public string Passa()
        {
            return $"{Nome} esta Pasando ";
        }
    }
}