namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        public string Carro { get; set; }
        public string Placa { get; set; }


        public string aceitarPassageiro( string nome ){
            return "Você aceitou a corrida de"+nome;
        }

        public bool receberPagamento(string status){
            if(status == "Pagamento aprovado"){
                return true;
            }
            return false;
        }

    }
}