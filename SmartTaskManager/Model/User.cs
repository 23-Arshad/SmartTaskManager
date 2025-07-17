namespace SmartTaskManager.Model
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "User";
        public DateTime CreatedDateTime { get; set; }
    }
}
