using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : ijogador
    {
        public readonly string _Nome;
        public Jogador1 (string nome = "Rommel ")
        {
            _Nome = nome;
        }

        //Chutar
        public string Chutar ()
        {
            return $"{_Nome}está Chutando \n";
        }

        //Correr
        public string Correr ()
        {
            return $"{_Nome}está Correndo \n";
        }

        //Passe
        public string Passe ()
        {
            return $"{_Nome}está Passando!";
        }
    }
}