using IdeaPath.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPath.BLL.Services
{
    public class BaseService 
    {
        public IdeaPathEntities Db;
        public BaseService(IdeaPathEntities db)
        {
            this.Db = db;
        }
        public BaseService()
        {
            this.Db = new IdeaPathEntities();
        }
    }
}
