using System;

namespace Dojo
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }        
        public string Nacionalidade { get; set; }
        public DateTime Nascimento {get; set;} 
        public int Idade { get; set; } 
        public float Altura { get; set; }
        public float Peso { get; set; }
        
        public int CalcularIdade(){
            int AnoAtual = Int32.Parse( DateTime.Now.ToString().Split("/")[2].Split()[0] );
            
            
            int AnoNascimento = Int32.Parse(Nascimento.ToString().Split("/") [2].Split(" ") [0]);

            Idade = AnoAtual - AnoNascimento;
            
            return Idade;
        } 
                                                                    
        public void MostrarDados(){
            Console.WriteLine($"Nome: {Nome}, Posição: {Posicao}, Nascimento {Nascimento}");
        }

        public string VerificarAposentadoria(){
            string Retorno = "";
            if(Idade >= 35 && Posicao == "Atacante"){
                Retorno = "O Atacante pode se aposentar";
            }else if (Idade >= 38 && Posicao == "Meio Campista"){
                Retorno = "O Meio Campista pode se aposentar";
            }else if(Idade >= 40 && Posicao == "Defensor"){
                Retorno = "O Defensor pode se aposentar";
            }else{
                Retorno = "O jogador não tem idade o suficiente para se aposentar";
            }
            return Retorno;
        }
    }
}