using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Banco
    {
        private List<ContaBancaria> contas = new List<ContaBancaria>();

        private ContaBancaria BuscarConta(int numeroContaDigitado)
        {
            return contas.Find(conta => conta.numeroConta == numeroContaDigitado);
        }


        public void CriarConta()
        {
            Console.WriteLine("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine($@"escolha o tipo de conta
1 - Corrente
2 - Poupanca");
            int tipo = int.Parse(Console.ReadLine());

            ContaBancaria novaConta = tipo == 1 ? new ContaCorrente(titular) : new ContaPoupanca
                (titular);

            contas.Add(novaConta);
            Console.WriteLine($"Conta {novaConta.numeroConta} criada com sucesso!");

        }

        public void Depositar()
        {
            Console.WriteLine("Digite o numero da conta: ");
            int numeroContaDigitado = int.Parse(Console.ReadLine());

            ContaBancaria contaBuscada = BuscarConta(numeroContaDigitado);

        if(contaBuscada != null)
            {
                Console.WriteLine("Digite o valor do deposito: ");
                double valor = double.Parse(Console.ReadLine());
                contaBuscada.Depositar(valor);
            }
        else
            {
                Console.WriteLine("Conta nao encontrada!");
            }
        }
 
        public void Sacar()
        {
            Console.WriteLine("Digite o numero da conta: ");
            int numeroContaDigitado = int.Parse (Console.ReadLine());

            ContaBancaria contaBuscada = BuscarConta(numeroContaDigitado);

            if(contaBuscada != null)
            {
                Console.WriteLine("digite o valor do saque: ");
                double valor= double.Parse(Console.ReadLine());
                contaBuscada.Sacar(valor);
            }
            else
            {
                Console.WriteLine("Conta nao encontrada");
            }
        }


        public void Listar()
        {
            if (contas.Count > 0)
            {
                foreach (var conta in contas)
                {
                    conta.ConsultarSaldo();
                }
            }
            else
            {
                Console.WriteLine("encontrado");
            }
        }
    }
}
