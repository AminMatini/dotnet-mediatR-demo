using MediatR;

namespace Demo.Api.Application.Notifications;

public class EmailNotificationHandler : INotificationHandler<EmailNotification>
{
    private readonly ILogger<EmailNotificationHandler> _logger;

    public EmailNotificationHandler(ILogger<EmailNotificationHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EmailNotification notification, CancellationToken cancellationToken)
    {
        _logger.LogWarning("Sending Email to {EmailAddress} with content {EmailContent}", notification.EmailAddress, notification.EmailContent);
        return Task.CompletedTask;
    }
}