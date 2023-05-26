using Demo.Api.Data.Model;
using Demo.Api.Data.Repositories;
using MediatR;

namespace Demo.Api.Application.BookApplication.AddBook;

public class AddBookRequestHandler : IRequestHandler<AddBookRequest, bool>
{
    private readonly IBookRepository _bookRepository;

    public AddBookRequestHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public Task<bool> Handle(AddBookRequest request, CancellationToken cancellationToken)
    {
        _bookRepository.AddBook(new Book
        { Author = request.Author, Id = request.Id, PublishYear = request.PublishYear, Title = request.Title });

        return Task.FromResult(true);
    }
}