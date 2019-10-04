namespace ByteBank.Cliente
{
    public class contacorrente
    {
                public Cliente Titular{get;set;}
                public int Agencia{get;set;}
                public int Numero{get;set;}
                public double saldo{get;set;}

                
                public contacorrente(int Numero, int Agencia, Cliente titular){
                this.Numero = Numero;
                this.Agencia = Agencia;
                this.Titular = Titular;
                this.saldo = 0.0;
                } 
                
                //public bool Deposito(double saque){
                //if (saque > 0) {
                    //return true;
                //} else {
                    //return false;
                //}
                //}

                //public bool transferencia(double transferencia){
                //if (transferencia > 0) {
                    //return true;
                //} else {
                    //return false;
                //}
                //}
                
                public double Deposito(double valor){
                    return this.saldo += valor;
                }

                public bool saque(double valor){
                    if(saldo >= valor){
                        saldo -= valor;
                        return true;
                    } else { 
                        return false;
                    }
                }

                public bool transferencia(contacorrente contaDestino, double valor){
                    if(this.saque(valor)){
                        contaDestino.Deposito(valor);
                        return true;
                    } else {
                        return false;
                    }
                }

        }

    }
