namespace Aula13Uber
{
    public class Usuario
    {

        //Propriedade resumida
        public string Nome { get; set; }

        //Propriedade completa
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { 
                if(idade > 0){
                    idade = value;
                } 
            }
        }

        public int Foto { get; set; }
        private string login = "gustavo@gmail.com";
        public string senha = "123456789";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }
        public string TipoAcesso { get; set; }

        

        public bool Login(string login, string senha){

            if( this.login == login && this.senha == senha){
                TokenLogin = "akjdhnwuifnqiugjnbquincqwuiphdf";
                return true;
            }
            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }
        

    }
}