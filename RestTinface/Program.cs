using RestSharp;
using System.Text.Json;

RestClient client = new("https://onepiecelogs.dev/api");


string character = "roronoa_zoro";
RestRequest request = new($"characters/{character}");

RestResponse response = client.GetAsync(request).Result;

// Console.WriteLine(response.Content);

Character p = JsonSerializer.Deserialize<Character>(response.Content);



Console.WriteLine(p.name);
Console.WriteLine(p.age);
Console.WriteLine(p.bounty);
Console.WriteLine(p.birthday);
Console.ReadLine();