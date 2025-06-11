using NTierTodoApp.DataAccess;

namespace NTierTodoApp.Business
{
    public class TaskService
    {
        private readonly TaskRepository taskRepository;

        public TaskService(TaskRepository repository)
        {
            taskRepository = repository;
        }

        public List<TaskItem> GetTasks()
        {
            return taskRepository.GetAll();
        }

        public void AddTask(string title)
        {
            taskRepository.Add(new TaskItem { Title = title, IsCompleted = false });
        }

        public void CompleteTask(int id)
        {
            taskRepository.MarkCompleted(id);
        }

        public void DeleteTask(int id)
        {
            taskRepository.Remove(id);
        }

        // تعديل عنوان المهمة
        public void EditTask(int id, string newTitle)
        {
            taskRepository.UpdateTitle(id, newTitle);
        }
    }
}
