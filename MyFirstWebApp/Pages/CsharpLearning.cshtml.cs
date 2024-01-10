using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWebApp.Models;
using System.Xml.Linq;

namespace MyFirstWebApp.Pages
{
    public class CsharpLearningModel : PageModel
    {
        //
        // Properties
        //

        private readonly ILogger<CsharpLearningModel> _logger;

        //
        // Methods
        //

        public CsharpLearningModel(ILogger<CsharpLearningModel> logger)
        {
            _logger = logger;

            _logger.Log(LogLevel.Information, "Constructor() called!");
        }

        public void OnGet()
        {
            // Logging messages
            _logger.Log(LogLevel.Information, "OnGet() called!");

            // Data types
            int myInt = 5;
            decimal myDecimal = 2.50M;
            bool myBool = false;
            string myText = "Hello C#!!!!";

            int myOtherInt;
            myOtherInt = 20;

            // var type is deferred until runtime
            var myVar = "Hello World!";

            // Operators
            int sum = myInt + myOtherInt;
            _logger.Log(LogLevel.Information, "Sum: " + sum);

            // Strings
            string newText = myText.ToUpper();
            _logger.Log(LogLevel.Information, "Uppercase text: " + newText);

            // If Statements
            if(myInt > 5)
            {
                _logger.Log(LogLevel.Information, "myInt is greater than 5");
            }
            else if(myInt < 5)
            {
                _logger.Log(LogLevel.Information, "myInt is less than 5");
            }
            else
            {
                _logger.Log(LogLevel.Information, "myInt is equal to 5");
            }

            // Collections

            //int[] myNums = new int[myInt];
            //int[] myNums = {0,1,2,3,4,5};
            string[] numStrings = {"hello","world"};
            string newString = numStrings[0] + numStrings[1];
            _logger.Log(LogLevel.Information, "Arrays are fun - " + newString);

            List<string> namesList = new List<string>();
            namesList.Add("Mike");
            namesList.Add("Joe");
            namesList.Add("Sue");
            //namesList.Remove("Sue");

            int numNames = namesList.Count();
            _logger.Log(LogLevel.Information, "My list has " + numNames + " friends.");

            // Loops (counter, condition, increment)
            _logger.Log(LogLevel.Information, "My friends (for):");
            for (int i = 0; i < numNames; i++) 
            {
                _logger.Log(LogLevel.Information, namesList.ElementAt(i));
            }

            _logger.Log(LogLevel.Information, "My friends (foreach):");
            foreach (string name in namesList)
            {
                _logger.Log(LogLevel.Information, name);
            }


            // Classes and Models - using "old" way of creating a model class

            Friend_OtherWay myFirstFriend;
            myFirstFriend = new Friend_OtherWay("Mike", "Smith", "mike@nscc.ca");
            Friend_OtherWay mySecondFriend = new Friend_OtherWay("Han", "Solo", "hansolo@nscc.ca");
            Friend_OtherWay myThirdFriend = new Friend_OtherWay("Luke", "Skywalker", "luke@nscc.ca");

            // Instatiate without constructor values
            Friend_OtherWay myForthFriend = new Friend_OtherWay();
            myForthFriend.SetFirstName("Leia");
            myForthFriend.SetLastName("Organa");
            myForthFriend.SetEmail("leia@nscc.ca");

            // A List<type> can be most type really
            List<Friend_OtherWay> friendList = new List<Friend_OtherWay>();
            friendList.Add(myFirstFriend);
            friendList.Add(mySecondFriend);
            friendList.Add(myThirdFriend);

            foreach(Friend_OtherWay friend in friendList)
            {
                _logger.Log(LogLevel.Information, friend.GetFirstName() + " " + friend.GetLastName());
            }

            // Classes and Models - using "new" way of creating a model class
            Friend friend1 = new Friend();
            friend1.FirstName = "Mike";
            friend1.LastName = "Smith";
            friend1.Email = "mike@nscc.ca";

            Friend friend2 = new Friend()
            {
                FirstName = "Han",
                LastName = "Solo",
                Email = "han@nscc.ca"
            };





        }
    }
}
