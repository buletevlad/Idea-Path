using IdeaPath.BLL.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static IdeaPath.BEL.Enums.Enums;

namespace IdeaPath.UnitTest.ServiceTests
{
    [TestClass]
    public class DatabaseServiceTests : BaseService
    {
         DatabaseService service = new DatabaseService();

        // Project
        [TestMethod]
        public void Get_Projects_from_Db()
        {
            // Act
            var projects = service.GetProjects();
            
            // Assert
            Assert.AreNotEqual(projects.Count, 0);
        }
        // Idea
        [TestMethod]
        public void Get_Ideas_from_Db()
        {
            // Arrange
            int id = 2;
            // Act
            var idea = service.GetIdeaById(id);

            // Assert
            Assert.IsNotNull(idea);
        }
        [TestMethod]
        public void Get_Ideas_for_Task()
        {
            // Arrange
            int id = 2;
            // Act
            var ideas = service.GetIdeasForTask(id);

            // Assert
            Assert.IsNotNull(ideas);
        }
        // Task
        [TestMethod]
        public void Get_Tasks_For_Project()
        {
            // Arrange
            int id = 2;
            // Act
            var tasks = service.GetTasksForProject(id);

            // Assert
            Assert.IsNotNull(tasks);
        }
        [TestMethod]
        public void TestEnums()
        {
            var x = (int)StatusEnum.Finished;
            var idea = service.GetIdeaById(2);
            if (x == idea.StatusId)
            {
                Assert.IsNotNull(1);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
