namespace UserManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // required
        public string Email { get; set; } = string.Empty; // required
        public int Age { get; set; }
    }
}
