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

        // Freind object
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

            // Add some addresses
            List<Address> addresses = new List<Address>();
            
            addresses.Add(new Address()
            {
                Street = "1 Robie St.",
                City = "Halifax",
                Province = "NS",
                Country = "CA",
                PostalCode = "B6D4S2"
            });

            // Another way to add the address
            Address address2 = new Address();
            address2.Street = "22 Portland St.";
            address2.City = "Dartmouth";
            address2.Province = "NS";
            address2.Country = "CA";
            address2.PostalCode = "B9M6X3";
            addresses.Add(address2);

            friend.Addresses = addresses;

            _logger.Log(LogLevel.Information, "# of addresses= " + addresses.Count());
        }

        public void OnGet()
        {
            _logger.Log(LogLevel.Information, "OnGet() called!");


        }

        public void OnPost()
        {
            _logger.Log(LogLevel.Information, "OnPost() called!");
        }


    }
}
