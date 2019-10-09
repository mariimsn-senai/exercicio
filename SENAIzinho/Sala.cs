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
            this.NomeAluno = NomeAluno;

            Alunos[capacidadeTotal - 1] = NomeAluno;

            capacidadeTotal = capacidadeTotal - 1;
            
        }
    

        public void RemoverAluno (string Alunos)
        {
        if ((index < 0) || (index > todoList.Count - 1))
                {

                    string nome;
                    System.Console.WriteLine("Nome do Aluno: ");
                    string nome = Console.ReadLine();
                    Alunos.RemoveAt(nome);
                }else {
                }
        }
        }

        public void MostrarAlunos ()
        {

        }

    }
