using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Passageiro gustavo = new Passageiro();
            gustavo.Nome = "Gustavo";


            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();
            
            System.Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            gustavo.Login(login, senha);

            if(gustavo.TokenLogin != "" && gustavo.TokenLogin != null){
                System.Console.WriteLine("Login autorizado");

                System.Console.WriteLine("-------------------------");

                System.Console.WriteLine(gustavo.SolicitarMotorista());
                System.Console.WriteLine("O motorista Jonas aceitou sua corrida");


                System.Console.WriteLine("Qual vai ser o local de início?");
                string localInicio = Console.ReadLine();
                
                System.Console.WriteLine("Qual vai ser o local final?");
                string localChegada = Console.ReadLine();

                
                
            }else{
                System.Console.WriteLine("Não é possivel realizar o login");
            }
            
            

                




            
            


        }
    }
}
