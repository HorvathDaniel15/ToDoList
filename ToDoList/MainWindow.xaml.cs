using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string filepath = "tasks.json";
        public ObservableCollection<TaskItem> Tasks { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<TaskItem>();
            LoadTasks();
            TasksListBox.ItemsSource = Tasks;
        }

        private void LoadTasks()
        {
            if (File.Exists(filepath))
            {
                var json = File.ReadAllText(filepath);
                var tasks = JsonSerializer.Deserialize<ObservableCollection<TaskItem>>(json);
                if (tasks != null)
                {
                    Tasks = tasks;
                }
            }
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskTextBox.Text))
            {
                Tasks.Add(new TaskItem { Name = TaskTextBox.Text });
                TaskTextBox.Clear();
                SaveTask();
            }
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveTask()
        {
            throw new NotImplementedException();
        }
    }
}
