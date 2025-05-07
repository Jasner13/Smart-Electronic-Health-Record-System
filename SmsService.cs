using System;
using System.Threading.Tasks;
using Vonage;
using Vonage.Request;
using Vonage.Messaging;

namespace SEHRS
{
    public static class SmsService
    {
        public static async Task<bool> SendSmsAsync(string phoneNumber, string message)
        {
            try
            {
                var credentials = Credentials.FromApiKeyAndSecret(
                    "61876d35",   
                    "jtRHFXsfGd1zEQam" 
                );
                
                var client = new VonageClient(credentials);
                string formattedNumber = FormatPhoneNumber(phoneNumber);

                var response = await client.SmsClient.SendAnSmsAsync(new SendSmsRequest
                {
                    To = formattedNumber,
                    From = "SEHRS", 
                    Text = message
                });

                Console.WriteLine($"Status: {response.Messages[0].Status}");
                Console.WriteLine($"Message ID: {response.Messages[0].MessageId}");

                return response.Messages[0].Status == "0";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Vonage SMS Error: {ex.Message}");
                return false;
            }
        }

        public static string FormatPhoneNumber(string phoneNumber)
        {
            phoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

            if (phoneNumber.StartsWith("0") && phoneNumber.Length == 11)
            {
                return "63" + phoneNumber.Substring(1);
            }
            else if (phoneNumber.StartsWith("63") && phoneNumber.Length == 12)
            {
                return phoneNumber;
            }
            else if (phoneNumber.StartsWith("9") && phoneNumber.Length == 10)
            {
                return "63" + phoneNumber;
            }

            throw new FormatException($"Invalid PH number: {phoneNumber}");
        }
    }
}
