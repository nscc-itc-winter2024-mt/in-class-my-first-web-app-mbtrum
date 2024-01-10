namespace MyFirstWebApp.Models
{
    public class Friend_OtherWay
    {
        /// <summary>
        ///  This is one way to define a model (data) class
        ///  Explicitly defining the get() and set() methods
        /// </summary>
        /// 
        
        private string FirstName;
        private string LastName;
        private string Email;

        // This is one way to set the variable values
        public Friend_OtherWay(string firstName = "", string lastName = "", string email = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        public void SetEmail(string email)
        {
            Email = email;
        } 
    }
}
