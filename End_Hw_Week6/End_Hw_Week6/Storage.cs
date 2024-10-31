
namespace End_Hw_Week6
{
    public static class Storage
    {
        //
       public static Book[] books = new Book[20];
       public static User[] users = new User[20];
        public static int BookCount = 0;
        public static int UserCount = 0;
        static Storage()
        {
            books[0] = new Book(0, "c#", "ela");
            books[1] = new Book(1, "python", "amir");
            books[2] = new Book(2, "java", "leila");
            books[3] = new Book(3, "php", "taha");
            BookCount = 4;

            users[0] = new User("sara@gmail.com", "1234", UserRole.Member);
            users[1] = new User("asra@gmail.com", "1234", UserRole.Member);
            users[2] = new User("zahra@gmail.com", "1234", UserRole.Librarian);
            UserCount = 3;

        }

    }
    
}
