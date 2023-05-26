using MediatR;

namespace Demo.Api.Application.BookApplication.AddBook;

public class AddBookRequest : IRequest<bool>
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public int PublishYear { get; set; }
}
