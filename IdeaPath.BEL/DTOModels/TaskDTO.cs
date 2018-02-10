using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPath.BEL.DTOModels
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedDate { get; set; }

        public TaskDTO(IdeaPath.DAL.Models.Task x)
        {
            Id = x.Id;
            ProjectId = x.ProjectId;
            StatusId = x.StatusId;
            Name = x.Name;
            Description = x.Description;
            UpdatedDate = x.UpdatedDate;
        }
    }

    
}
