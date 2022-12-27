using ShoppingApi.API.EmailServices.Abstract;

namespace ShoppingAPI.API.EmailServices.Concrete
{
    public class Pop3EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}
