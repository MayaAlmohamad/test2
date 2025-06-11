using DataAccess;
using DataAccess.Models;
using System.Collections.Generic;

namespace NTierTodoApp.Business
{
    public class TaskService
    {
        private readonly TaskRepository taskRepository;

        public TaskService()
        {
            taskRepository = new TaskRepository();
        }

        public List<TaskItem> GetTasks()
        {
            return taskRepository.GetAll();
        }

        public void AddTask(string title)
        {
            taskRepository.Add(title);
        }

        public void CompleteTask(int id)
        {
            taskRepository.Complete(id);
        }

        public void DeleteTask(int id)
        {
            taskRepository.Delete(id);
        }

        public void EditTask(int id, string newTitle)
        {
            taskRepository.UpdateTitle(id, newTitle);
        }
    }
}
