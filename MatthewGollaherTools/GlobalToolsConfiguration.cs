using System.Collections.Generic;

namespace GlobalTools.BusinessLogic
{
    public class GlobalToolsConfiguration
    {
        public string UserFullName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string TwilioAccountSid { get; set; }
        public string TwilioAuthToken { get; set; }
        public string TwilioPhoneNumber { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SenderEmail { get; set; }
        public string SenderPassword { get; set; }
        public string EmailSubject { get; set; }
        public List<string> UserEmails { get; set; }
    }
}
