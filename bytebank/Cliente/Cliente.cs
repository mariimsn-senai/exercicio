namespace   ByteBank.Cliente

{
    public class Cliente
    {

                public string _Cpf;
                public string _Nome;
                public string _Email;
                public string _Senha;

        public string Senha{
            
            get {return _Senha;}
        }

        public string Cpf
        {
            get {return _Cpf;}
            set { _Cpf = value;}
        }
        public string Nome
        {
            get {return _Nome;}
            set { _Nome = value;}
        }
        public string Email
        {
            get {return _Email;}
            
        }
                

                public Cliente(string Cpf, string Nome, string Email) {
                    this.Cpf = Cpf;
                    this._Nome = Nome;
                    this._Email = Email;
                                        }
                public bool TrocaSenha(string senha) {
                    if ((senha.Length > 6) && (senha.Length < 16)){
                        this._Senha = senha;
                        return true;
                    }else{ 
                        return false;
                    }
                }
    }
}