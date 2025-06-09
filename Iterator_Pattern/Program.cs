public class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }
}

// Iterator interface
public interface IBookIterator
{
    bool HasNext();
    Book Next();
}

// Iterator implementation
public class BookIterator : IBookIterator
{
    private readonly List<Book> _books;
    private int _position = 0;

    public BookIterator(List<Book> books)
    {
        _books = books;
    }

    public bool HasNext()
    {
        return _position < _books.Count;
    }

    public Book Next()
    {
        return _books[_position++];
    }
}

public class BookCollection
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public IBookIterator GetIterator()
    {
        return new BookIterator(books);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var collection = new BookCollection();
        collection.AddBook(new Book("Design Patterns"));
        collection.AddBook(new Book("Clean Code"));
        collection.AddBook(new Book("The Pragmatic Programmer"));

        var iterator = collection.GetIterator();

        Console.WriteLine("Book List:");
        while (iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine("- " + book.Title);
            /*
                Output: Book List:
                Output: - Design Patterns
                Output: - Clean Code
                Output: - The Pragmatic Programmer
            */
        }
    }
}