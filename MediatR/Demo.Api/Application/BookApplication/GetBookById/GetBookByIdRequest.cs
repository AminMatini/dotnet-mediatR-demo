using Demo.Api.Data.Model;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Demo.Api.Application.BookApplication.GetBookById;

public class GetBookByIdRequest : IRequest<Book>
{
    [Required]
    public string BookId { get; set; } = null!;
}
