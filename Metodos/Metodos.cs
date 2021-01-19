// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using static System.Console;

// namespace CONTABANCARIA
// {
//     public class Metodos
//     {

//         public void Execucao()
//         {


//             // var conta1 = new Conta()
//             // {
//             //     Agencia = 987,
//             //     Banco = "Banco Mercadona",
//             //     NumeroConta = 567,
//             //     Saldo = 10000
//             // };

//             // var cliente1 = new Cliente()
//             // {
//             //     Nome = "Nelismy Baro",
//             //     Idade = 34,
//             //     Email = "tuta2020@gmail.com",
//             //     Telefone = "5521987654",
//             //     CPF = "71489965432",
//             //     Endereco = "Rua Pechincha numero 24"
//             // };

//             /* Deposito*/
//             Console.WriteLine();
//             Console.WriteLine("Digite seu nome: " + "\n");
//             var nome = Console.ReadLine();
//             Console.WriteLine("Digite CPF: " + "\n");
//             var cpf = Console.ReadLine();
//             Console.WriteLine("Informe um valor para deposito:" + "\n");
//             var valor = Console.ReadLine();

//             /*Saque*/
//            // Console.WriteLine();
//             //Console.WriteLine ("Digiteseu nome: " + "\n");
//             //var nome = Console.ReadLine();
//             //Console.WriteLine("Informe um valor para o saque:" + "\n");
//             //var valor = Console.ReadLine();


//             var valor1 = Convert.ToDouble(Console.ReadLine());

//             var conta = new ContaCorrente()
//             {
//                 Banco = "Banco Itaú",
//                 Agencia = 2123,
//                 NumeroConta = 234,
//                 Saldo = 1000,
//                 Titular = "Lorenzo",
//             };

//             var saque = conta.Sacar(valor);
//             var deposito = conta.Deposito(valor);


//             /* Imprime as informações da conta do cliente que realizou deposito*/
//             Console.WriteLine("------------------------------------");
//             Console.WriteLine();
//             Console.WriteLine("Dados da conta do cliente");
//             Console.WriteLine();
//             Console.WriteLine($"Olá {nome}," + "\n" + "seu depósito foi realizado com sucesso!" + "\n" + $"Valor depositado: {valor}" + "\n");
//             Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {deposito}");
//             Console.ReadKey();
//             Console.WriteLine("------------------------------------");
//             Console.ReadKey();
            

//             /*Imprime as informações da conta do cliente que realizou o saque */
//             Console.WriteLine("------------------------------------");
//             Console.WriteLine();
//             Console.WriteLine("Dados da conta do cliente");
//             Console.WriteLine();
//             Console.WriteLine($"Olá {nome}," + "\n" + "seu saque foi realizado com sucesso!" + "\n" + $"Valor sacado: {valor}" + "\n");
//             Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {saque}");
//             Console.ReadKey();
//             Console.WriteLine("------------------------------------");
//             Console.ReadKey();


//         }


        
//     }
// }