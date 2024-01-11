using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Pages
{
    public class RazorLearningModel : PageModel
    {
        //
        // Properties
        //

        private readonly ILogger<RazorLearningModel> _logger;

        public string pageModelMessage = "Welcome to Model Binding!!!";

        public string[] pets = { "dog", "cat", "hamster" };

        public Friend friend = new Friend() { 
            FirstName = "Lando", 
            LastName = "Carlissian", 
            Email = "lando@nscc.ca" 
        };

        //
        // Methods
        //

        public RazorLearningModel(ILogger<RazorLearningModel> logger)
        {
            _logger = logger;

            _logger.Log(LogLevel.Information, "Constructor() called!");
        }

        public void OnGet()
        {
            _logger.Log(LogLevel.Information, "Onget() called!");


        }
    }
}
