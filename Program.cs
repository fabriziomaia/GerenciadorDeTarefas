// Program.cs
using GerenciadorDeTarefas.Data;
using GerenciadorDeTarefas.Models;
using System;
using System.Linq;

// Garante que o banco de dados seja criado na primeira execução
using (var db = new AppDbContext())
{
    // db.Database.EnsureCreated(); // Alternativa mais simples que migrations para projetos locais
}

while (true)
{
    Console.WriteLine("\n--- Gerenciador de Tarefas ---");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Listar Todas as Tarefas");
    Console.WriteLine("3. Marcar Tarefa como Concluída");
    Console.WriteLine("4. Remover Tarefa");
    Console.WriteLine("5. Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            AdicionarTarefa();
            break;
        case "2":
            ListarTarefas();
            break;
        case "3":
            MarcarComoConcluida();
            break;
        case "4":
            RemoverTarefa();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

// CREATE
void AdicionarTarefa()
{
    Console.Write("Título da tarefa: ");
    string titulo = Console.ReadLine();
    
    Console.Write("Descrição: ");
    string descricao = Console.ReadLine();

    var novaTarefa = new Tarefa
    {
        Titulo = titulo,
        Descricao = descricao,
        DataDeCriacao = DateTime.Now,
        Concluida = false
    };

    using (var db = new AppDbContext())
    {
        db.Tarefas.Add(novaTarefa);
        db.SaveChanges(); // Salva as alterações no banco
    }
    
    Console.WriteLine("Tarefa adicionada com sucesso!");
}

// READ
void ListarTarefas()
{
    using (var db = new AppDbContext())
    {
        var tarefas = db.Tarefas.ToList();
        if (!tarefas.Any())
        {
            Console.WriteLine("Nenhuma tarefa encontrada.");
            return;
        }

        Console.WriteLine("\n--- Lista de Tarefas ---");
        foreach (var tarefa in tarefas)
        {
            string status = tarefa.Concluida ? "Concluída" : "Pendente";
            Console.WriteLine($"ID: {tarefa.Id} | Título: {tarefa.Titulo} | Status: {status}");
            Console.WriteLine($"  Descrição: {tarefa.Descricao}\n");
        }
    }
}

// UPDATE
void MarcarComoConcluida()
{
    Console.Write("Digite o ID da tarefa para marcar como concluída: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        using (var db = new AppDbContext())
        {
            var tarefa = db.Tarefas.Find(id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                db.SaveChanges();
                Console.WriteLine("Tarefa atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
    }
    else
    {
        Console.WriteLine("ID inválido.");
    }
}

// DELETE
void RemoverTarefa()
{
    Console.Write("Digite o ID da tarefa para remover: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        using (var db = new AppDbContext())
        {
            var tarefa = db.Tarefas.Find(id);
            if (tarefa != null)
            {
                db.Tarefas.Remove(tarefa);
                db.SaveChanges();
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
    }
    else
    {
        Console.WriteLine("ID inválido.");
    }
}