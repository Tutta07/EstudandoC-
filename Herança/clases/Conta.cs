using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;


namespace ContaBancaria.Herança
{
    public class Conta
    {
        public int Agencia {get; set;}
        public int NumeroConta {get; set;}
        public double Saldo { get;set;}
        public string Banco { get; set;}
        public Conta TipoConta {get; set;}
        
    }
}