using System;

namespace Aula13Uber
{
    public class Cartao : Passageiro
    {
        private string numero;
        private string titular { get; set; }
        private string Bandeira { get; set; }
        private string cvv { get; set; }


        public string CadastrarCartao(){
            System.Console.WriteLine("Digite o número do seu cartão: ");
            string numero = Console.ReadLine();

            System.Console.WriteLine("Digite o nome do titular do cartão: ");
            string titular = Console.ReadLine();

            System.Console.WriteLine("Digite a bandeira do seu cartão: ");
            string Bandeira = Console.ReadLine();

            System.Console.WriteLine("Digite o cvv de seu cartão: ");
            string cvv = Console.ReadLine();


            return "Cartão cadastrado";
        }


    }
}