using System;

namespace ContaBancaria.Polimorfismo1
{
    public class Polimorfismo
    {
        //polimorfismo el metodo puede ser con igual nombre pero con parametros diferentes, o pueden ser metodos iguales son parametros iguales pero de tipo diferentes.
        //escrita igual pero con comportamiento diferente.
        //"solid" fechado para modificacion e aberto para criacao o extensao, sobre carga de metodo => principios del solid.
        public void Execucao()
        {
            Console.WriteLine("Digite o primeiro número:");
            var numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o segundo número:");
            var numero2 = Convert.ToInt32(Console.ReadLine());

            var soma = Somar(numero1,numero2);
        }
        private int Somar(int numero1, int numero2)
        {
            var result= numero1+numero2;
            return result;
        }

        public int Somar()
        {
            var result = 0;
            return result;
        }
        public int Somar(int n1, int n2,int n3, bool verifica)
        {
            var resultado=0;
            return resultado;
        }

        

    }

}