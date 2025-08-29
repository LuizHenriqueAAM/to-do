namespace Services;
using Models;
using Spectre.Console;

public class ServiceTask
{

	// This list stores all tasks created by the CreateTask method.
	public static List<TodoTask> TaskList = new List<TodoTask>();

	// Create a task and store it on the TaskList
	public static void CreateTask(string TaskName, string TaskDescription)
	{
		int TasksInList = TaskList.Count() + 1;
		TodoTask NewTask = new TodoTask(TaskName, TaskDescription, TasksInList);
		TaskList.Add(NewTask);
	}

	// This method write on the console all tasks stored on the TaskList
	public static void ListAllTasks()
	{
		if (TaskList.Count == 0)
		{
			Console.WriteLine("No tasks registered.");
		}
		foreach (var task in TaskList)
		{
			Console.WriteLine(task);
		}

	}
	//This method returns a task by its Id, or null if its is not found on the TaskList
	public static TodoTask? GetTaskById(int TargetTaskId)
	{
		foreach (var task in TaskList)
		{
			if (task.TaskId == TargetTaskId)
			{
				return task;
			}
		}
		return null;
	}

	// This method calls GetTaskById to pass the returned Task Objecto to be removed
	public static void RemoveTargetTask(int TargetTaskId)
	{
		TodoTask? TaskToRemove = GetTaskById(TargetTaskId);
		if (TaskToRemove == null)
		{
			Console.WriteLine("Task not found!");
			return;
		}
		TaskList.Remove(TaskToRemove!);
		Console.WriteLine("Task removed!");
	}
	public static void CompleteTask(int TargetTaskId)
	{
		TodoTask? TaskToFinish = GetTaskById(TargetTaskId);
		if (TaskToFinish == null)
		{
			Console.WriteLine("Task not found!");
			return;
		}
		TaskToFinish.TaskIsDone = true;
		Console.WriteLine("Task marked as complete!");
	}
}
