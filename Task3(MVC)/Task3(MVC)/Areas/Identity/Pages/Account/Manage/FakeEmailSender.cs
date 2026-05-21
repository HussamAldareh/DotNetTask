using Microsoft.AspNetCore.Identity.UI.Services;

public class FakeEmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // ما بعمل اشي - بس عشان نرضي Identity 😅
        return Task.CompletedTask;
    }
}