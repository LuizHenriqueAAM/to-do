namespace Models;

public class TodoTask
{
	public int TaskId { get; set; }
	public string? TaskName { get; set; }
	public string? TaskDescription { get; set; }
	public bool TaskIsDone { get; set; }
	public DateTime TaskCreationDate { get; set; }

	public TodoTask(string name, string description, int id)
	{
		this.TaskId = id;
		this.TaskName = name;
		this.TaskDescription = description;
		this.TaskIsDone = false;
		this.TaskCreationDate = DateTime.Now;
	}
	public override string ToString()
	{
		return $"[ID: {TaskId}] {TaskName} - {TaskDescription} | Created at: {TaskCreationDate:dd/MM/yyyy HH:mm} | Finished: {TaskIsDone}";
	}
}
