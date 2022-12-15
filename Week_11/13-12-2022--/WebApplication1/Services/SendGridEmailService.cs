namespace WebApplication1.Services
{
    public class SendGridEmailService: IEmailService
    {
        public void Send(string to, string message, string topic)
        {
            To(to, message, topic);
        }

        public void To(string to,string message,string topic)
        {
            Console.WriteLine($"SendGrid: {to}-{topic} {message}");

        }
    }
}
