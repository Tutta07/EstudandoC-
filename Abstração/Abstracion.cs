using System;

namespace ContaBancaria.Abstração
{
    public class Abstracion{
        public void Execucao()
        {
            var quadrado = new Quadrado();
            Console.WriteLine(quadrado.Descricao());
            Console.WriteLine("Informe o lado do quadrado em metros.");
            quadrado.Lado = Convert.ToInt32(Console.ReadLine());

            quadrado.CalcularArea();
            quadrado.CalcularPerimetro();
            Console.WriteLine($"A àrea do quadrado é:  {quadrado.Area} m2");
            Console.WriteLine($"O perímetro do quadrado é:  {quadrado.Perimetro} m2");
            Console.ReadLine();


        }
    

    public abstract class Form
    {
        public double Area {get; set;}
        public string  Cor {get; set;}
        public double Perimetro {get; set;}
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        public string Descricao()
        {
            return "Sou a clase abstracta Forma";
        }

    }

    public  class Quadrado: Form
    {
        public double Lado {get;set;}
        public override void CalcularArea()
        {
            Area= Lado * Lado;
        }
            public override void CalcularPerimetro()
            {
                Perimetro= 4 * Lado;
            }
    
    }
}
}