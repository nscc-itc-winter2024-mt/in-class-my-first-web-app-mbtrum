using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Pages
{
    public class BindingLearningModel : PageModel
    {
        private readonly ILogger<BindingLearningModel> _logger;

        [BindProperty]
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        public Pet Pet { get; set; } = new Pet(); 


        public BindingLearningModel(ILogger<BindingLearningModel> logger)
        {
            _logger = logger;

            _logger.Log(LogLevel.Information, "Constructor() called!");
        }

        public void OnGet()
        {
            _logger.Log(LogLevel.Information, "OnGet() is called.");

            // Set a default value for when a message is called
            Message = "Enter a message";
        }

        public void OnPost()
        {
            _logger.Log(LogLevel.Information, "OnPost() is called.");

            // Output the Message this is set from the [BindProperty] - two-way binding
            _logger.Log(LogLevel.Information, "Message web client entered: " + Message);

            // More complex two-way binding
            _logger.Log(LogLevel.Information, "Pet: " + Pet.Name + " is " + Pet.Age + " years old.");
        }
    }
}
