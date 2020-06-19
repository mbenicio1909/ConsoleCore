using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1:iJogador
    {
        public string Nome { get; set; }

        public Jogador1(string nome  ="Ronaldo")
        {
            Nome=nome;
            
        }
            public string Chuta()
        {
            return $"{Nome} esta Chutando ";
        }
        public string Corre()
        {
            return $"{Nome} esta  Correndo";
        }

        public string Passa()
        {
            return $"{Nome} esta Passando ";
        }
    }
}