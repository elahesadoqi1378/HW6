
namespace End_Hw_Week6
{
    public enum UserRole
    {
        Member=0,
        Librarian = 1
        
    }
    public class User
    {
        public User(string email,string password , UserRole role)
        {
            Email = email;
            Password = password;
            Role = role;
            
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public Book[] BorrowedBooks { get; set; } = new Book[15];
    }
}
