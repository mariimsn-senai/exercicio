using System;

namespace mac
{
    class Cliente
    {
        
            //propriedade
    public string Nome;     //Nome do cliente
    public string Endereço;     //Endereço do cliente 
    public string Telefone;     //telefone do cliente 
    public string Senha;        //senha de acesso do cliente
    public string Email;        //Emael do cliente e nome de usuario do sistema
    public DateTime DataNascimento; //Data de nascimento do cliente
            
    //Construtores

    public Cliente(string Nome, string Telefone, string Email){
        this.Nome = Nome;
        this.Telefone = Telefone;
        this.Email = Email;
    }
    }
}
