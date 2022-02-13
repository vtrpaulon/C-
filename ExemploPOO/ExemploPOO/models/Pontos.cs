using System;
namespace ExemploPOO.models
{
    public class Pontos
    {
        private int ponto;
        private int bonus;
        private bool valido;

        public void IncluirValores(int ponto, int bonus)
        {
            if(ponto > 0 && bonus > 0)
            {
                this.ponto = ponto;
                this.bonus = bonus;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("Valor invalido");
            }
            
        }
        
        public int MostrarPontos()
        {
            if(valido)
            {
                return ponto + bonus;
            }
            else
            {
                System.Console.WriteLine("Informe valores validos");
                return 0;
            }
            
        }
    }
}
