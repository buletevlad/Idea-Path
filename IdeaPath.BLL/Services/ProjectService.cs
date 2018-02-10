using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IdeaPath.BEL.Enums.Enums;

namespace IdeaPath.BLL.Services
{
    public class ProjectService : BaseService
    {
        DatabaseService databaseService = new DatabaseService();

        /// <summary>
        /// set status = finished if all tasks are finished
        /// </summary>
        /// <param name="projectId"></param>
        public void SetStatusForTask(int projectId)
        {
            var tasks = databaseService.GetTasksForProject(projectId);
            bool allTasksFinished = true;
            allTasksFinished = tasks.Exists(y => y.StatusId != (int)StatusEnum.Finished);
            if (allTasksFinished == false)
            {
                var project = databaseService.GetProjectById(projectId);
                project.StatusId = (int)StatusEnum.Finished;
                Db.SaveChanges();
            }
        }
    }
}
