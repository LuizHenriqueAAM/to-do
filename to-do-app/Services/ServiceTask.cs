namespace Services;
using Models;
public class ServiceTask
{
	List<TodoTask> TaskList = new List<TodoTask>();

    // This method aims to create a Task object and stores it on the TaskList
    public void CreateTask(string TaskName, string TaskDescription)
	{
		int TasksInList = TaskList.Count()+1;
		TodoTask NewTask = new TodoTask(TaskName, TaskDescription, TasksInList);
	}
}
