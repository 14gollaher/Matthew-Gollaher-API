using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace GlobalTools.BusinessLogic
{
    public class EmailNotification
    {
        private readonly GlobalToolsConfiguration _configuration;

        public EmailNotification(GlobalToolsConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendEmail(string message)
        {
            Parallel.ForEach(_configuration.UserEmails, item =>
            {
                MimeMessage mimeMessage = BuildEmail(message, item);
                SendEmail(mimeMessage);
            });
        }

        private MimeMessage BuildEmail(string message, string recipientEmail)
        {
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress(_configuration.SenderEmail));
            mimeMessage.To.Add(new MailboxAddress(recipientEmail));
            mimeMessage.Subject = _configuration.EmailSubject;
            mimeMessage.Body = new TextPart("plain")
            {
                Text = message

            };
            return mimeMessage;
        }

        private void SendEmail(MimeMessage mimeMessage)
        {
            using (var client = new SmtpClient())
            {
                client.Connect(_configuration.SmtpServer, _configuration.SmtpPort, false);
                client.Authenticate(_configuration.SenderEmail, _configuration.SenderPassword);
                client.Send(mimeMessage);
                client.Disconnect(true);
            }
        }
    }
}