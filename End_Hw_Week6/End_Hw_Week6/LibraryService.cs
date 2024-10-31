

namespace End_Hw_Week6
{
    public class LibraryService : ILibraryService
    {
        public void BorrowBook(string name , User user)
        {
            for(int i = 0; i<Storage.BookCount; i++)
            {
                if (Storage.books[i].Name == name && !Storage.books[i].IsBorrowed)
                {
                    Storage.books[i].IsBorrowed = true;
                    Console.WriteLine("book"+ " " +name+" "+"borrowed");
                    return;
                }

            }
            Console.WriteLine("book" + " " + name + " is not available(or you entered invalid name)");

        }

        public void ReturnBook(string name , User user)
        {
          for(int i =0; i < Storage.BookCount; i++)
            {
                if (Storage.books[i].Name == name && Storage.books[i].IsBorrowed)
                {
                    Storage.books[i].IsBorrowed = false;
                    Console.WriteLine(name + " returned to library");
                    return;


                }
                else
                {
                    Console.WriteLine("this book is not available (or you entered invalid name)");
                    return;
                }


            }
        }

        public void GetListOfLibraryBooks()
        {
            Console.WriteLine("available books are:");
            for(int i = 0; i < Storage.BookCount; i++)
            {
                if (!Storage.books[i].IsBorrowed)
                {
                    Console.WriteLine($"{Storage.books[i].Name} written by {Storage.books[i].Author}");
                }
            }
        }

        public void GetListOfUserBooks(User user)
        {
            Console.WriteLine($"{user.Email}'s Borrowed Books:");
            for (int i = 0; i < Storage.BookCount; i++)
            {
                if (Storage.books[i].IsBorrowed)
                {
                    Console.WriteLine(Storage.books[i].Name);
                }
            }


        }


    }
}
