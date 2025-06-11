using DataAccess.Models;

namespace DataAccess
{
    public class TaskRepository
    {
        private readonly List<TaskItem> tasks = new List<TaskItem>();
        private int nextId = 1;

        public List<TaskItem> GetAll()
        {
            return tasks;
        }

        public void Add(string title)
        {
            tasks.Add(new TaskItem
            {
                Id = nextId++,
                Title = title,
                IsCompleted = false
            });
        }

        public void Complete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                task.IsCompleted = true;
        }

        public void Delete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                tasks.Remove(task);
        }

        public void UpdateTitle(int id, string newTitle)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                task.Title = newTitle;
        }
    }
}
