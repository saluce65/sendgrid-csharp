using System;
using SendGrid.Helpers.Mail; // If you are using the Mail Helper
using Newtonsoft.Json; // You can generate your JSON string yourelf or with another library if you prefer

string _apiKey = Environment.GetEnvironmentVariable("SENDGRID_APIKEY", EnvironmentVariableTarget.User);
dynamic sg = new SendGrid.SendGridAPIClient(_apiKey);

////////////////////////////////////////////////////////
// Retrieve email statistics by browser. 
// GET /browsers/stats

string queryParams = @"{
  'aggregated_by': 'day', 
  'browsers': 'test_string', 
  'end_date': '2016-04-01', 
  'limit': 'test_string', 
  'offset': 'test_string', 
  'start_date': '2016-01-01'
}";
dynamic response = await sg.client.browsers.stats.get(queryParams: queryParams);
Console.WriteLine(response.StatusCode);
Console.WriteLine(response.Body.ReadAsStringAsync().Result);
Console.WriteLine(response.Headers.ToString());
Console.ReadLine();

