using Demo.Api.Application.BookApplication.AddBook;
using Demo.Api.Application.BookApplication.GetBookById;
using Demo.Api.Application.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers;

[ApiController]
[Route("Api/Books")]
public class BookController : ControllerBase
{
    private readonly IMediator _mediator;

    public BookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetBook")]
    public async Task<IActionResult> GetBookById(string id)
    {
        var book = await _mediator.Send(new GetBookByIdRequest { BookId = id });

        if (book == null)
            return NotFound();

        return Ok(book);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> CreateBook(AddBookRequest request)
    {
        var command = await _mediator.Send(request);

        if (command)
        {
            await _mediator.Publish(new EmailNotification("admin@site.com", "A New Book Was Added"));

            return Ok();
        }
        return BadRequest();
    }
}

