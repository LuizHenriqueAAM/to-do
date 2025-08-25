namespace to_do_app;

using Models;
using Services;
class Program
{
    public static void Main(string[] args)
    {
        ServiceTask.CreateTask("Teste", "Teste");

        ServiceTask.ListAllTasks();
    }
}
