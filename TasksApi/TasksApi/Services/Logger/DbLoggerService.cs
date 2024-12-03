using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TasksApi.Models;

namespace TasksApi.Services.Logger
{
    public class DbLoggerService: ILoggerService

    {
        private readonly TasksDbContext _tasksDbContext;
        
        public DbLoggerService(TasksDbContext context)
        {
            _tasksDbContext = context;
        }
        public void Log(string message)
        {
            Log log = new Log()
            {
                Message = message
            };
            _tasksDbContext.Log.Add(log);
            _tasksDbContext.SaveChanges();

        }

    }
}
