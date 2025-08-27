namespace to_do_app;

using Models;
using Services;
using Spectre.Console;
using Spectre.Console.Cli;
class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        var Option = "";
        while (Option != "Quit Application")
        {
            Option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What do you want to do?")
                    .PageSize(10)
                    .AddChoices(new[] {
                        "Create a Task", "List All Tasks", "Remove One Task", "Mark a Task as finished", "Quit Application"
                    }
                )
            );

            if (Option == "Create a Task")
            {
                AnsiConsole.MarkupLine("[underline green]Name your task:[/]");
                string TaskName = Console.ReadLine()!;
                AnsiConsole.MarkupLine("[underline green]Describe your task:[/]");
                string TaskDescription = Console.ReadLine()!;
                ServiceTask.CreateTask(TaskName, TaskDescription);
            }
            if (Option == "List All Tasks")
            {
                var panel = new Panel("List of Tasks");
                panel.Header("Tasks");
                panel.Border = BoxBorder.Square;
                panel.Expand = true;
            }


        }
        Console.Clear();
        
    }
}
