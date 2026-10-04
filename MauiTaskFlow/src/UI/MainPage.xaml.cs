using MauiTaskFlow.Data;
using MauiTaskFlow.Model;

namespace MauiTaskFlow.UI;

public partial class MainPage : ContentPage
{
    public List<TaskItem> Tasks { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Tasks = TaskData.GetTasks();

        BindingContext = this;
    }
}