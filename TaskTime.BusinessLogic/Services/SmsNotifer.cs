using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TaskTime.BusinessLogic
{
    public class SmSNotifer
    {
        private readonly ITwilioRestClient _restClient;
        private readonly TaskTimeConfiguration _configuration;

        public SmSNotifer(TaskTimeConfiguration configuration)
        {
            _configuration = configuration;
            _restClient = new TwilioRestClient(_configuration.TwilioAccountSid, _configuration.TwilioAuthToken);

        }

        public async Task SendMessagesAsync(string message)
        {

            await MessageResource.CreateAsync(
                new PhoneNumber(_configuration.UserPhoneNumber),
                from: new PhoneNumber(_configuration.TwilioPhoneNumber),
                body: message,
                client: _restClient);
        }
    }
}