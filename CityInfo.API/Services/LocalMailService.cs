namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo = "Admin@mycompany.com";
        private string _mailFrom = "noreply@mycompany.com";

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail From {_mailFrom} to {_mailTo}, with {nameof(LocalMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
