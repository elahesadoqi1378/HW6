
namespace End_Hw_Week6
{
    public interface ILibraryService
    {
        void BorrowBook(string name,User user);
        void ReturnBook(string name , User user);
        void GetListOfLibraryBooks();
        void GetListOfUserBooks(User user);


    }
}
