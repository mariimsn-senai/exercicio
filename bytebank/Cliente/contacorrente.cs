namespace bytebank.Cliente
{
    public class contacorrente
    {
                public string Titular;
                public int Agencia;
                public int Numero;
                public double Saldo;

                public contacorrente(int Numero, int Agencia, string Titular){
                this.Numero = Numero;
                this.Agencia = Agencia;
                this.Titular = Titular;

                } 
                
                    public bool TrocaSaldo(string Saldo) {
                    if (senha.Length > 0){
                        this.Senha = senha;
                        return true;
                    }else{ 
                        return false;
                    }
                    }

    }
}