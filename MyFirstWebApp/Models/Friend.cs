namespace MyFirstWebApp.Models
{
    public class Friend
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;  
        
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
