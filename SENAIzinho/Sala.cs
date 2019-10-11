namespace SENAIzinho
{
    public class Sala
    {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos;
        
        
        public Sala(int numeroSala, int capacidadeTotal)
        {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.Alunos = new string [capacidadeTotal];
        }

        public void AlocarAluno (string NomeAluno)
        {
        if(capacidadeAtual > 10)
            {
            Alunos[capacidadeTotal - 1] = NomeAluno;

            capacidadeTotal = capacidadeTotal - 1;
            System.Console.WriteLine("cadastro com sucesso");
            }
            else
            {
                System.Console.WriteLine("cadastro invalido");
            }

            
        }
    

        public void RemoverAluno (string Alunos)
        {
            string index;
        if (Alunos.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    index = string.Parse(Alunos) - 1;
                }

                if ((index < 0) || (index > Alunos.Count - 1))
                {
                    System.Console.WriteLine("ID Inválido!");
                    System.Console.WriteLine("Pressione <ENTER> para continuar");
                    Console.ReadLine();
                }
                else
                {
                    todoList.RemoveAt(index);
                }
        }
        

        public void MostrarAlunos()
        {

        }

    }
}
