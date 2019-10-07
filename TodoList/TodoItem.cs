namespace TodoList
{
    public class TodoItem
    {
        public string Titulo;
        public string Notas;
        public TodoItem(string titulo, string nota)
        {
            this.Titulo = titulo;
            this.Notas = nota;
        }
    }
}