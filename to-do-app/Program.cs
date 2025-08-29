namespace to_do_app;

using Models;
using Services;
using Spectre.Console;
using Spectre.Console.Cli;

class Program
{
    public static void Main(string[] args)
    {
        AnsiConsole.Clear();
        ServiceTask.CreateTask("Teste", "teste");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        ServiceTask.CreateTask("Teste2", "teste2");
        // Create the layout
        var layout = new Layout("Root")
            .SplitColumns(
                new Layout("Left"),
                new Layout("Right")
                    .SplitRows(
                        new Layout("Top"),
                        new Layout("Bottom")));
        // Update the left column
        layout["Left"].Update(
            new Panel(
                Align.Center(
                    new Markup("Hello [blue]World![/]"),
                    VerticalAlignment.Middle))
                .Expand());

        var table = new Table();
        table = table.AddColumn("ID");
        table = table.AddColumn("Tasks");

        for (int i = 0; i < ServiceTask.TaskList.Count; i++)
        {
            table = table.AddRow((i+1).ToString(), ServiceTask.TaskList[i].ToString());
        }

        layout["Top"].Update(
            new Panel(table)
                .Header("tasks")
                .Expand()
        );

        // Render the layout
        AnsiConsole.Write(layout);
    }
}
