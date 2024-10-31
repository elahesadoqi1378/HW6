using End_Hw_Week6;

public class Program
{
    private static Authentication authService = new Authentication();
    private static LibraryService libraryService = new LibraryService();
    private static User LoggedInUser;

    public static void Main(string[] args)
    {
       Start(); //ebham
    }

    public static void Start()
    {
         Console.WriteLine("=====Welcome To E-Library======");
        while (true)
        {
            Console.WriteLine("1.Register");
            Console.WriteLine("2.Login");
            Console.WriteLine("3.Exit");




            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    RegisterUser();
                    break;
                case "2":
                    if (LoginUser())
                    {
                        UserMenu();
                    }
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    private static void RegisterUser()
    {
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        Console.Write("Enter role (0 for Member, 1 for Librarian): ");
        UserRole role =(UserRole)Convert.ToInt32((Console.ReadLine()));

        authService.Register(email, password, role);
    }

    private static bool LoginUser()
    {
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (authService.Login(email, password))
        {
            // peyda krdne user
            foreach (var user in Storage.users)
            {
                if (user?.Email == email) 
                {
                    LoggedInUser = user;
                    return true;
                }
            }
            return true;
        }
        return false;
    }

    private static void UserMenu()
    {
        string input;
        do
        {
            Console.WriteLine("Library Menu:");
            Console.WriteLine("1. View all library books");
            Console.WriteLine("2. Borrow a book");
            Console.WriteLine("3. Return a book");
            Console.WriteLine("4. View borrowed books");
            Console.WriteLine("5. Logout");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    libraryService.GetListOfLibraryBooks();
                    break;
                case "2":
                    Console.Write("Enter book name to borrow: ");
                    string borrowname = Console.ReadLine();
                    libraryService.BorrowBook(borrowname, LoggedInUser);
                    break;
                case "3":
                    Console.Write("Enter book name to return: ");
                    string returnname = Console.ReadLine();
                    libraryService.ReturnBook(returnname, LoggedInUser);
                    break;
                case "4":
                    libraryService.GetListOfUserBooks(LoggedInUser);
                    break;
                case "5":
                    LoggedInUser = null;
                    Console.WriteLine("Logged out successfully.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        } while (LoggedInUser != null);
    }
}
