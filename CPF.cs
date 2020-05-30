namespace Herança
{
    public class CPF
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(){
            if(cpf !=""){
                return  true;
            }
                return false;
        }
    }
}