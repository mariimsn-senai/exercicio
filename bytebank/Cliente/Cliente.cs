namespace   ByteBank.Cliente

{
    public class Cliente
    {

                public string Cpf;
                public string Nome;
                public string Email;
                public string Senha;

                public Cliente(string Cpf, string Nome, string Email) {
                    this.Cpf = Cpf;
                    this.Nome = Nome;
                    this.Email = Email;
                                        }
                public bool TrocaSenha(string senha) {
                    if ((senha.Length > 6) && (senha.Length < 16)){
                        this.Senha = senha;
                        return true;
                    }else{ 
                        return false;
                    }
                }
    }
}