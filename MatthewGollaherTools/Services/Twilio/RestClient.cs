using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.Clients;
using System.Threading.Tasks;

namespace GlobalTools.BusinessLogic
{
    public class RestClient : IRestClient
    {
        private readonly GlobalToolsConfiguration _configuration;

        public RestClient(GlobalToolsConfiguration configuration)
        {
            _configuration = configuration;
        }

        private readonly ITwilioRestClient _client;

        public RestClient()
        {
            _client = new TwilioRestClient(
                _configuration.TwilioAccountSid,
                _configuration.TwilioAuthToken
            );
        }

        public RestClient(ITwilioRestClient client)
        {
            _client = client;
        }

        public async Task<MessageResource> SendMessage(string from, string to, string body)
        {
            var toPhoneNumber = new PhoneNumber(to);
            return await MessageResource.CreateAsync(
                toPhoneNumber,
                from: new PhoneNumber(from),
                body: body,
                client: _client);
        }
    }
}