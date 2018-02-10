using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IdeaPath.BEL.Enums.Enums;

namespace IdeaPath.BLL.Services
{
    public class TaskService : BaseService
    {
        DatabaseService databaseService = new DatabaseService();



        /// <summary>
        /// set status = finished if all ideas are finished
        /// </summary>
        /// <param name="taskId"></param>
        public void SetStatusForTask(int taskId)
        {
            var ideas = databaseService.GetIdeasForTask(taskId);
            bool allIdeasFinished = true;
            allIdeasFinished = ideas.Exists(y => y.StatusId != (int)StatusEnum.Finished);
            if (allIdeasFinished == false)
            {
                var task = databaseService.GetTaskById(taskId);
                task.StatusId = (int)StatusEnum.Finished;
                Db.SaveChanges();
            }
        }
    }
}
