using System.Collections.Generic;
using System;
using Twilio.Rest.Api.V2010.Account;
using System.Threading.Tasks;


namespace TaskTime.BusinessLogic
{
    public interface IRestClient
    {
        Task<MessageResource> SendMessage(string from, string to, string body, List<Uri> mediaUrl);
    }
}
