using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : ijogador
    {
        public string Chutar()
        {
            return "Maradona estas pateando \n";
        }

        public string Correr()
        {
            return "Maradona estas corriendo \n";
        }

        public string Passe()
        {
            return "Maradona estas passeando \n";
        }
    }
}