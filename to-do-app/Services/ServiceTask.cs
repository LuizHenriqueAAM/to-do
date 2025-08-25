namespace Services;
using Models;
public class ServiceTask
{
	public static List<TodoTask> TaskList = new List<TodoTask>();

	// This method aims to create a Task object and stores it on the TaskList
	public static void CreateTask(string TaskName, string TaskDescription)
	{
		int TasksInList = TaskList.Count() + 1;
		TodoTask NewTask = new TodoTask(TaskName, TaskDescription, TasksInList);
		TaskList.Add(NewTask);
	}

	public static void ListAllTasks()
	{
		TaskList.ForEach(task => Console.WriteLine(task));
	}
	public static void RemoveTask(TodoTask Task)
	{
		ListAllTasks.RemoveTask(Task);
	}
}
