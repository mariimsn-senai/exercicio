using System;
using System.Collections.Generic;
using System.IO;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TodoItem> todoList = new List<TodoItem>();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;
            //faz valor a segunda barra

            try
            {
                string[] todoFile = File.ReadAllLines(filePath);

                foreach (var line in todoFile)
                {
                    string[] item = line.Split(",");
                    string titulo = item[0].Replace("\"", "");
                    //o que voce quer substuir no codigo, se não escrever nada no "" ele só apaga
                    string nota = item[1].Replace("\"", "");

                    TodoItem todoItem = new TodoItem(titulo, nota);
                    //todoItem está dentro só do foreach
                    todoList.Add(todoItem);
                }
            }
            catch (IOException ioe)
            {
                System.Console.WriteLine("erro ao aacessar arquivo");
                System.Console.WriteLine(ioe.Message);
            }

            int opcao = 0;

            do
            {
                Console.Clear();
                System.Console.WriteLine("TODO LIST");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Escolha uma opção:");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Adicionar Item");
                System.Console.WriteLine("2 - Remover um item da lista");
                System.Console.WriteLine("3 - Sair do programa");
                System.Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AddItem(todoList);
                        break;
                    case 2:
                        RemoveItem(todoList);
                        break;
                    case 3:
                        System.Console.WriteLine("tchau");
                        SaveItem(todoList, filePath);
                        break;
                    default:
                        System.Console.WriteLine("opção invalida");
                        Console.ReadLine();
                        break;
                }
            } while (opcao != 3);
        }

        public static void ListaItens(List<TodoItem> todoList)
        {
            int count = 1;
            System.Console.WriteLine("Todo List");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID {"",2} Titulo{"",12} Notas");
            foreach (TodoItem item in todoList)
            {
                System.Console.WriteLine($"{count,3}: {item.Titulo,-15} - {item.Notas}");
                count++;
            }
        }
        public static void AddItem(List<TodoItem> todoList)
        {
            Console.Clear();
            System.Console.WriteLine("Novo Item: ");
            System.Console.WriteLine();
            System.Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            System.Console.WriteLine("Nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo, nota);

            todoList.Add(item);
        }

        public static void RemoveItem(List<TodoItem> todoList)
        {
            int index = 0;
            do
            {
                Console.Clear();
                System.Console.WriteLine("Remove Itens");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o ID ou x para terminar.");
                System.Console.Write("Id: ");
                string id = Console.ReadLine();

                if (id.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    index = int.Parse(id) - 1;
                }

                if ((index < 0) || (index > todoList.Count - 1))
                {
                    System.Console.WriteLine("ID Inválido!");
                    System.Console.WriteLine("Pressione <ENTER> para continuar");
                    Console.ReadLine();
                }
                else
                {
                    todoList.RemoveAt(index);
                }
            } while (true);
        }
        public static void SaveItem(List<TodoItem> lista, string filePath)
        {
            List<string> linhas = new List<string>();
            linhas.Add("tile,notas");
            foreach (TodoItem item in lista)
            {
                string titulo = "\"" + item.Titulo + "\"";
                string nota = "\"" + item.Notas + "\"";
                linhas.Add(titulo + "," + nota);
            }
            string tryAgain = "n";
            do
            {
                try
                {
                    File.WriteAllLines(filePath, linhas);
                }
                catch (IOException e)
                {
                    Console.WriteLine("Erro na gravação do arquivo.");
                    System.Console.WriteLine(e.Message);
                    do
                    {
                        System.Console.WriteLine("Desejar tentar novamente?");
                        tryAgain = Console.ReadLine().ToLower();

                    } while (tryAgain == "s" || tryAgain == "n");
                }
            } while (tryAgain != "n");
        }

    }
}

