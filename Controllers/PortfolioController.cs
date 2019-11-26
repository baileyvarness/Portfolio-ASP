using Microsoft.AspNetCore.Mvc;
namespace PortfolioController.Controllers
{
    public class PortfolioController
    {
        [HttpGet]
        [Route("/")]
        public string Index()
        {
            return "This is my index!";
        }

        [HttpGet]
        [Route("/projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet]
        [Route("/contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}