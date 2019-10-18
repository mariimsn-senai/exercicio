namespace ByteBank2.Models
{
    public class ContaEsperimental : ContaBancaria
    {
        public double Limite;
        public ContaEsperimental(int Agencia, int NumeroConta, string Titular) :base(Agencia,NumeroConta,Titular)
        {
            Limite = 0.0;
        }

        public bool SetLimite(double Valor)
        {
            if(Valor >=0)
            {
                Limite = Valor;
                return true;
            }
            return false;
        }
        public override bool Saque(double Valor)
        {
            if(Valor >=0)
            {
                if(Valor <= Saldo + Limite) 
                {
                    Saldo -= Valor;
                    return true;
                }
                
            }
            return false;
        }
    }
}