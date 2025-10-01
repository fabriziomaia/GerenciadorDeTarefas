# Projeto Gerenciador de Tarefas em C# com Entity Framework Core

Este projeto é uma aplicação de console desenvolvida como parte do Challenge de Desenvolvimento de Software. O objetivo é demonstrar os conceitos de C#, .NET e o uso do Entity Framework Core para realizar operações CRUD (Create, Read, Update, Delete) em um banco de dados.

## Sobre a Aplicação

O Gerenciador de Tarefas permite ao usuário:
- Adicionar novas tarefas com título e descrição.
- Listar todas as tarefas cadastradas, exibindo seu status (Pendente ou Concluída).
- Marcar uma tarefa existente como concluída.
- Remover uma tarefa do sistema.

## Membros do Grupo

- Fabrizio Maia - RM551869

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Plataforma:** .NET 8
- **ORM:** Entity Framework Core 8
- **Banco de Dados:** SQLite

## Como Configurar e Rodar o Projeto

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.

### Passos para Execução

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd seu-repositorio
    ```

3.  **Restaure as dependências do projeto:**
    ```bash
    dotnet restore
    ```

4.  **Aplique as migrações para criar o banco de dados:**
    *(Esta etapa é crucial para que o banco de dados seja criado corretamente)*
    ```bash
    dotnet ef database update
    ```

5.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

Após a execução, um menu interativo aparecerá no console, permitindo que você utilize todas as funcionalidades da aplicação.
