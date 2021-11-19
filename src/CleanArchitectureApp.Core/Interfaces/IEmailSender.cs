using System.Threading.Tasks;

namespace CleanArchitectureApp.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
