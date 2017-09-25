using System.Collections.Generic;

namespace TaskTime.BusinessLogic
{
    public class TaskTimeConfiguration
    {
        public string UserFullName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string TwilioAccountSid { get; set; }
        public string TwilioAuthToken { get; set; }
        public string TwilioPhoneNumber { get; set; }
    }
}
