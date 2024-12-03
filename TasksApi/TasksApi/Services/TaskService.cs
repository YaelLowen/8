using TasksApi.Models;
using TasksApi.Repository;

namespace TasksApi.Services
{
    public class TaskService : ITaskService
    {

        Logger1 logger = new Logger1();
        private readonly ITaskRepository _taskRepository;

        private readonly GenericRepository<Tasks> _tasksRepository;
        private readonly TasksApi.Services.Logger.ILoggerService _ILoggerService;
        public TaskService(ITaskRepository taskRepository, GenericRepository<Tasks> tasksRepository, TasksApi.Services.Logger.ILoggerService iLoggerService)
        {
            _taskRepository = taskRepository;
            _tasksRepository = tasksRepository;
            _ILoggerService = iLoggerService;
        }

        public void CreateTask(Tasks task)
        {
           _taskRepository.CreateTask(task);
            _taskRepository.CreateTask(task);
        }

        public void DeleteTask(Tasks task)
        {
           
            _taskRepository.DeleteTask(task);
        }

        public List<Tasks> GetAllTasksByUser(int userId)
        {

            return _taskRepository.GetAllTasks().Where(x=>x.UserId==userId).ToList();  
        }

        public List<TasksWithUsers> GetAllTasksWithUser()
        {
            _ILoggerService.Log("all task");

            return _taskRepository.GetAllTasksWithUsers();
        }

        public void UpdateTask(Tasks task)
        {
           _taskRepository.UpdateTask(task);
        }
    }
}
