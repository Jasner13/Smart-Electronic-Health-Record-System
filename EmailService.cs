using System.Net.Mail;
using System.Net;

public static class EmailService
{
    public static void SendEmail(string toEmail, string subject, string body)
    {
        var fromAddress = new MailAddress("smartehrsystem@gmail.com", "SEHRS Notification"); 
        var toAddress = new MailAddress(toEmail);
        const string fromPassword = "nuugpnckmqcbmttl"; 
        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        };

        using (var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        })
        {
            smtp.Send(message);
        }
    }
}
