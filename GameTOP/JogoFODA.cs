using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly ijogador _jogadorA;
        private readonly ijogador _jogadorB;

        public JogoFODA(ijogador jogadorA, ijogador jogadorB, Lib.Jogador3 jogador3)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Correr());
            System.Console.Write(_jogadorA.Chutar());
            System.Console.Write(_jogadorA.Passe());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(_jogadorB.Correr());
            System.Console.Write(_jogadorB.Chutar());
            System.Console.Write(_jogadorB.Passe());
        }
    }
}