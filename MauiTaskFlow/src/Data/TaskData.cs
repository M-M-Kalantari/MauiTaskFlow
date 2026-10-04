using MauiTaskFlow.Model;

namespace MauiTaskFlow.Data;

public static class TaskData
{
    public static List<TaskItem> GetTasks()
    {
        return
        [
            new TaskItem
            {
                Title = "Learn C#",
                Description = "Practice C# basics and object-oriented programming",
                DueDate = "Today",
                DueTime = "20:30",
                Priority = "Medium"
            },

            new TaskItem
            {
                Title = "Build MAUI project",
                Description = "Create the main layout for MauiTaskFlow",
                DueDate = "Today",
                DueTime = "21:30",
                Priority = "High"
            },

            new TaskItem
            {
                Title = "Study Android",
                Description = "Review RecyclerView and ViewModel concepts",
                DueDate = "Tomorrow",
                DueTime = "10:00",
                Priority = "Low"
            },

            new TaskItem
            {
                Title = "Complete university project",
                Description = "Prepare the next section of the presentation",
                DueDate = "Tomorrow",
                DueTime = "18:00",
                Priority = "High"
            },

            new TaskItem
            {
                Title = "Read documentation",
                Description = "Read the official MAUI documentation",
                DueDate = "Friday",
                DueTime = "16:00",
                Priority = "Medium"
            },

            new TaskItem
            {
                Title = "Practice XAML",
                Description = "Practice Grid, Border and StackLayout",
                DueDate = "Friday",
                DueTime = "19:30",
                Priority = "Low"
            },

            new TaskItem
            {
                Title = "Learn CollectionView",
                Description = "Understand ItemsSource and DataTemplate",
                DueDate = "Saturday",
                DueTime = "11:00",
                Priority = "Medium"
            },

            new TaskItem
            {
                Title = "Build TaskFlow",
                Description = "Implement the task creation screen",
                DueDate = "Saturday",
                DueTime = "15:30",
                Priority = "High"
            },

            new TaskItem
            {
                Title = "Review Git commands",
                Description = "Review branching, merging and rebasing",
                DueDate = "Sunday",
                DueTime = "17:00",
                Priority = "Low"
            },

            new TaskItem
            {
                Title = "Push project to GitHub",
                Description = "Commit and push the latest changes",
                DueDate = "Sunday",
                DueTime = "20:00",
                Priority = "Medium"
            }
        ];
    }
}