using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

class Program
{
    static void Main(string[] args)
    {
        const string accountSid = "ACa9b1fe99998105748d1819c8aec7530f";
        const string authToken = "a9b02a06a4f932a1fd3f5e84a8ab2a9e";
        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "Hello, how are you",
            from: new Twilio.Types.PhoneNumber("+15854969817"),
            to: new Twilio.Types.PhoneNumber("+92 312 1150399")
        );

        Console.WriteLine(message.Sid);
    }
}

