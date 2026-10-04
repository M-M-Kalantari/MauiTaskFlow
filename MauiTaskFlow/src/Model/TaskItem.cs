namespace MauiTaskFlow.Model;

public class TaskItem
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string DueDate { get; set; } = "";
    public string DueTime { get; set; } = "";
    public string Priority { get; set; } = "";
    public bool IsCompleted { get; set; }
}