using System;
using ContaBancaria.Abstração;
using ContaBancaria.Polimorfismo1;
//using ContaBancaria.Herança;
//using ContaBancaria.Clases_Objetos;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstracion
             var abstracion = new Abstracion();
             abstracion.Execucao();
             var polimorfismo = new Polimorfismo();
             polimorfismo.Execucao();
        
            // Conta conta = new Conta{
            //     Banco = "Banco Itaú",
            //     Agencia = 2123,
            //     NumeroConta = 234,
            //     Saldo = 1000

            // };
            // Cliente cliente = new Cliente{
            //     Nome = "Lorenzo",
            //     Idade = 30,
            //     Telefone = "2134565431",
            //     Email = "lorenz0rs@gmail.com",
            //     CPF = "00000000000",
            //     Endereco = "Rua X, numero 24"
            // };

            // var contacorriente = new ContaCorrente()
            // {
            //     Banco = "Banco Itaú",
            //     Agencia = 2123,
            //     NumeroConta = 234,
            //     Saldo = 1000,
            //     Titular = "Lorenzo",
            // };
            
            // Console.WriteLine("Dados do cliente");
            // Console.WriteLine("************************");
            // Console.WriteLine($"Nome {cliente.Nome}" + "\n");
            // Console.WriteLine($"Idade {cliente.Idade}" + "\n");
            // Console.WriteLine($"Telefone {cliente.Telefone}" + "\n");
            // Console.WriteLine($"Email {cliente.Email}" + "\n");
            // Console.WriteLine($"CPF {cliente.CPF}" + "\n");
            // Console.WriteLine($"Endereço {cliente.Endereco}" + "\n");
            // Console.WriteLine("************************");


            // Console.WriteLine($"Dados da Conta");
            // Console.WriteLine("************************");
            // Console.WriteLine($"Banco{contacorriente.Banco}" + "\n");
            // Console.WriteLine($"Agencia{contacorriente.Agencia}" + "\n");
            // Console.WriteLine($"Número da Conta{contacorriente.NumeroConta}" + "\n");
            // Console.WriteLine($"Saldo{contacorriente.Saldo}" + "\n");
            // Console.WriteLine("************************");

            // /* Deposito*/
            // Console.WriteLine();
            // Console.WriteLine("Digite seu nome: " + "\n");
            // var nome = Console.ReadLine();
            // Console.WriteLine("Digite CPF: " + "\n");
            // var cpf = Console.ReadLine();
            // Console.WriteLine("Informe um valor para deposito:" + "\n");
            // var valor = Convert.ToDouble(Console.ReadLine());
            // var deposito = contacorriente.Depositar(valor);
            // Console.WriteLine($"Foi depositado na sua conta a quantidade de: {valor}" + "\n");
          


            // /* Imprime as informações da conta do cliente que realizou deposito*/
            // Console.WriteLine("------------------------------------");
            // Console.WriteLine();
            // Console.WriteLine("Dados da conta do cliente");
            // Console.WriteLine();
            // Console.WriteLine($"Olá {nome}," + "\n" + "seu depósito foi realizado com sucesso!" + "\n" + $"Valor depositado: {valor}" + "\n");
            // Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.NumeroConta}" + "\n" + $"Saldo: {deposito}");
            // Console.WriteLine("------------------------------------");
           
            // Console.WriteLine("Vai realizar outra operação?");
            // Console.WriteLine("Saque");
            // Console.WriteLine("Transferência");
            // Console.WriteLine("Não");
            // var operacao = Console.ReadLine();
        
            // if (operacao == "Saque")
            // {  
            //       /*Saque*/
            //  Console.WriteLine("Informe um valor para o saque:" + "\n");
            //  var saque = Convert.ToDouble(Console.ReadLine());
            //  var saque1 = contacorriente.Sacar(saque);
            //  Console.WriteLine($"Foi debitado da sua conta a quantidade de: R {saque} " + "\n");

            //     /*Imprime as informações da conta do cliente que realizou o saque */
            // Console.WriteLine("------------------------------------");
            // Console.WriteLine();
            // Console.WriteLine("Dados da conta do cliente");
            // Console.WriteLine();
            // Console.WriteLine($"Olá {nome}," + "\n" + "seu saque foi realizado com sucesso!" + "\n" + $"Valor sacado: R {saque}" + "\n");
            // Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.NumeroConta}" + "\n" + $"Saldo: R {saque1}");
            // Console.ReadKey();
            // Console.WriteLine("------------------------------------");

            // }
            // else
            // {
                // if (operacao == "Transferência")
                // {
                //     Console.WriteLine("Informe um valor para a transferência:" + "\n");
                //     var transf_valor = Convert.ToDouble(Console.ReadLine());
                //     Console.WriteLine("Informe o numero de conta para a transferencia:" + "\n");
                //     ContaCorrente contadestino;
                //     contadestino.NumeroConta=Convert.ToInt32(Console.ReadLine());

                //     bool transferencia = contacorriente.Transferir(transf_valor,contadestino.NumeroConta);
                //     //Console.WriteLine($"Seu saldo agora é de: {Saldo} " + "\n");

                // }
            

            //     Console.WriteLine($"Obrigado {nome}, foi um prazer atender você");     
            // }

             
            



            
        }
        
        }
    }

