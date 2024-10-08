﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        var url = "https://example.com/api/endpoint";
        string filePath = "response.html";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                
                Console.WriteLine(response.StatusCode);

                string responseData = await response.Content.ReadAsStringAsync();

                await File.WriteAllTextAsync(filePath, responseData);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
