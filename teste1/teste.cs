using System;

namespace teste
{
   public class Teste    {
    //propriedade
   public string Nome;
    public string Curso;
    public string Cpf;
    public int[] Nota;

    //construtor agora vai precisar colocar cpf no nome do aluno
    public Teste(string Nome, string Cpf){
        this.Nome = Nome;
        this.Cpf = Cpf;
    }

    public Teste(string Nome, string Cpf, string Curso){
        this.Nome = Nome;
        this.Cpf = Cpf;
        this.Curso = Curso;
    }

    }
}
