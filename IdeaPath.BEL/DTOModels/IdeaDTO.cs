using IdeaPath.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPath.BEL.DTOModels
{
    public class IdeaDTO
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public int TypeId { get; set; }
        public string Text { get; set; }

        public IdeaDTO(Idea x)
        {
            Id = x.Id;
            TaskId = x.TaskId;
            StatusId = x.StatusId;
            TypeId = x.TypeId;
            Text = x.Text;
        }
        public IdeaDTO ToDTO(Idea x)
        {
            return new IdeaDTO(x);
        }
    }
}
