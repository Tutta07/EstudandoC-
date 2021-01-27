using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace ContaBancaria.Herança
{
    public class ContaCorrente : Conta
    {
        public int CodigoBanco { get; set;}
         public double Depositar(double valor)
        {
            Saldo += valor;
            return Saldo;
        }
            public double Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Não foi possivel concluir a transação. Seu saldo: {Saldo} é inferior ao valor solicitado {valor}.");
            }
            else
            {
                Saldo -= valor;
                return Saldo;
            }
            return Saldo;
        }


    }
}