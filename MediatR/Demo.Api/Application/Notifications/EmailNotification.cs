using MediatR;

namespace Demo.Api.Application.Notifications;

public class EmailNotification : INotification
{
    public string EmailAddress { get; }
    public string EmailContent { get; }

    public EmailNotification(string emailAddress, string emailContent)
    {
        EmailAddress = emailAddress;
        EmailContent = emailContent;
    }
}
