
namespace End_Hw_Week6
{
    public class Book
    {
        public Book(int id , string name , string author )
        {
            Id = id;
            Name = name;
            Author = author;
            IsBorrowed = false;
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }

    }
}
