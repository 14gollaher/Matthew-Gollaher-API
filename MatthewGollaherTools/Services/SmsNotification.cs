using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace GlobalTools.BusinessLogic
{
    public class SmsNotification
    {
        private readonly ITwilioRestClient _restClient;
        private readonly GlobalToolsConfiguration _configuration;

        public SmsNotification(GlobalToolsConfiguration configuration)
        {
            _configuration = configuration;
            _restClient = new TwilioRestClient(_configuration.TwilioAccountSid, _configuration.TwilioAuthToken);
        }

        public async System.Threading.Tasks.Task SendMessagesAsync(string message)
        {
            await MessageResource.CreateAsync(
                new PhoneNumber(_configuration.UserPhoneNumber),
                from: new PhoneNumber(_configuration.TwilioPhoneNumber),
                body: message,
                client: _restClient);
        }
    }
}