using Demo.Api.Data.Model;

namespace Demo.Api.Data.Repositories;

public interface IBookRepository
{
    List<Book> GetAllBooks();
    Book? GetBookById(string id);
    bool AddBook(Book book);
}

public class BookMockRepository : IBookRepository
{
    private List<Book> _books = new()
    {
        new Book{Title = "Title 1",Author ="Author 1",Id = "1",PublishYear = 2000},
        new Book{Title = "Title 2",Author ="Author 2",Id = "2",PublishYear = 2001},
        new Book{Title = "Title 3",Author ="Author 3",Id = "3",PublishYear = 2002},
        new Book{Title = "Title 4",Author ="Author 4",Id = "4",PublishYear = 2003},
        new Book{Title = "Title 5",Author ="Author 5",Id = "5",PublishYear = 2004},
    };

    public List<Book> GetAllBooks() 
        => _books;

    public Book? GetBookById(string id) 
        => _books.FirstOrDefault(b => b.Id.Equals(id));

    public bool AddBook(Book book)
    {
        _books.Add(book);
        return true;
    }
}
