using IdeaPath.BEL.DTOModels;
using IdeaPath.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPath.BLL.Services
{
    public class DatabaseService : BaseService
    {
        // Project
        public ProjectDTO GetProjectById(int id)
        {
            var project = Db.Projects.ToList().Where(x => x.Id == id).Select(x => new TaskDTO(x)).FirstOrDefault();
            return project;
        }
        public List<ProjectDTO> GetProjects()
        {
            var projects = Db.Projects.ToList().Select(x => new ProjectDTO(x)).ToList();
            return projects;
        }
        // Idea
        public List<IdeaDTO> GetIdeasByType(int typeId)
        {
            var ideas = Db.Ideas.Where(x=>x.TypeId == typeId).Select(x => new IdeaDTO(x)).ToList();
            return ideas;
        }
        public List<IdeaDTO> GetIdeasForTask(int taskId)
        {
            var ideas = Db.Ideas.ToList().Where(x => x.TaskId == taskId).Select(x => new IdeaDTO(x)).ToList();
            return ideas;
        }
        public IdeaDTO GetIdeaById(int id)
        {
            var idea = Db.Ideas.ToList().Where(x => x.Id == id).Select(x=> new IdeaDTO(x)).FirstOrDefault();
            return idea;
        }
        // Task
        public TaskDTO GetTaskById(int id)
        {
            var task = Db.Tasks.ToList().Where(x => x.Id == id).Select(x => new TaskDTO(x)).FirstOrDefault();
            return task;
        }
        public List<TaskDTO> GetTasksForProject(int projectId)
        {
            var tasks = Db.Tasks.ToList().Where(x => x.ProjectId == projectId).Select(x => new TaskDTO(x)).ToList();
            return tasks;
        }
    }
}
