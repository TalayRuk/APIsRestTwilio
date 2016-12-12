using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIsRestTwilio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            var client = new RestClient("https://api.twilio.com/2010-04-01");
            //2
            var request = new RestRequest("Accounts/{{Acount SID}}/Messages", Method.POST);
            //3
            request.AddParameter("To", "{{recipient's phone number}}");
            request.AddParameter("From", "{{sender's phone number}}");
            request.AddParameter("Body", "Hello world!");
            //4
            client.Authenticator = new HttpBasicAuthenticator("{{Account SID}}", "{{Auth Token}}");
            //5
            client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response);
            });
            Console.ReadLine();
        }
    }
}
