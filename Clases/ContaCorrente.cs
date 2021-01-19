using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace ContaBancaria
{
    public class ContaCorrente
    {
        public int Agencia {get; set;}
        public string Titular {get;set;}
        public int NumeroConta {get;set;}
        public double Saldo {get;set;}
        public string Banco {get;set;}

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

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {Saldo} é inferior ao valor que deseja transferir.{Saldo}");
            }
         
        
                Saldo -= valor;
                contaDestino.Depositar(valor);
                Console.WriteLine($"Transferencia realizada com sucesso. Seu saldo é de: {Saldo}");
                return true;
            
         
        }



       


    }
    
}