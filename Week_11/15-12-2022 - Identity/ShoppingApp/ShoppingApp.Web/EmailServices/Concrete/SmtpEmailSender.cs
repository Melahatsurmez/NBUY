using ShoppingApp.Web.EmailServices.Abstract;
using System.Net;
using System.Net.Mail;

namespace ShoppingApp.Web.EmailServices.Concrete
{
    public class SmtpEmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSl;
        private string _userName;
        private string _password;

        public SmtpEmailSender(string host, int port, bool enableSSl, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSSl = enableSSl;
            _userName = userName;
            _password = password;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_host, _port)
            {
                Credentials=new NetworkCredential(_userName, _password),
                EnableSsl=_enableSSl
            };
            return client.SendMailAsync(
                new MailMessage(_userName,email, subject, htmlMessage)
                {
                    IsBodyHtml=true
                });
        }
    }
}
