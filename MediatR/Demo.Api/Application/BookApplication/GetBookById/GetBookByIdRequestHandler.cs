using Demo.Api.Data.Model;
using Demo.Api.Data.Repositories;
using MediatR;

namespace Demo.Api.Application.BookApplication.GetBookById;

public class GetBookByIdRequestHandler : IRequestHandler<GetBookByIdRequest, Book?>
{
    private readonly IBookRepository _bookRepository;
    public GetBookByIdRequestHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public Task<Book?> Handle(GetBookByIdRequest request, CancellationToken cancellationToken) 
        =>  Task.FromResult(_bookRepository.GetBookById(request.BookId) ?? null);
}
