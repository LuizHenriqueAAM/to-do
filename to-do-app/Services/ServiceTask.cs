namespace Services;
using Models;
public class ServiceTask
{
	public static List<TodoTask> TaskList = new List<TodoTask>();

	public static void CreateTask(string TaskName, string TaskDescription)
	{
		int TasksInList = TaskList.Count() + 1;
		TodoTask NewTask = new TodoTask(TaskName, TaskDescription, TasksInList);
		TaskList.Add(NewTask);
	}

	public static void ListAllTasks()
	{
		if (TaskList.Count == 0)
		{
			Console.WriteLine("No tasks registered");
		}
		foreach (var task in TaskList)
		{
			Console.WriteLine(task);
		}

	}

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

	public static void RemoveTargetTask(int TargetTaskId)
	{
		TodoTask? TaskToRemove = GetTaskById(TargetTaskId);
		TaskList.Remove(TaskToRemove!);
	}
}
