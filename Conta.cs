namespace Aula13Uber
{
    public class Conta
    {
        public string agencia { get; set; }

        public string conta { get; set; }

        public string CadastrarConta(){
            return "Conta cadastrada";
        }

        public string Excluir(){
            return "Conta excluida";
        }
    }
}