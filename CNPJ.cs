namespace Herança
{
    public class CNPJ : pessoa
    {
        public string cnpj;
        public bool ValidarCNPJ(){
            if(cnpj != ""){
                return  true;
            }
                return false;
        }
    }
}