using System;

namespace Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador ribamar = new Jogador();
            ribamar.Nome = "Ribamar";
            ribamar.Posicao = "Atacante";
            ribamar.Peso = 80f;
            ribamar.Altura = 1.78f;
            ribamar.Nascimento = DateTime.Parse("21/05/1980");
            
            ribamar.CalcularIdade();
            Console.WriteLine(ribamar.VerificarAposentadoria());
            
        }
    }
}
