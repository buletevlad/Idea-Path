using IdeaPath.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPath.BEL.DTOModels
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }

        public ProjectDTO(Project x)
        {
            Id = x.Id;
            StatusId = x.StatusId;
            Name = x.Name;
            CreatedDate = x.CreatedDate;
            UpdatedDate = x.UpdatedDate;
        }
    }
}
