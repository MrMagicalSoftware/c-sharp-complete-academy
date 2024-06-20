// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{


   


    static async Task Main(string[] args)
    {
        // Creare un'istanza di HttpClient
        using HttpClient client = new HttpClient();

        try
        {
            // Effettuare una richiesta GET all'API
            HttpResponseMessage response = await client.GetAsync("https://randomfox.ca/floof/");
            response.EnsureSuccessStatusCode();

            // Leggere il contenuto della risposta come stringa
            string responseBody = await response.Content.ReadAsStringAsync();

            // Analizzare il JSON
            JsonDocument jsonDoc = JsonDocument.Parse(responseBody);
            JsonElement root = jsonDoc.RootElement;

            // Estrarre l'URL dell'immagine
            string imageUrl = root.GetProperty("image").GetString();

            // Stampare l'URL dell'immagine
            Console.WriteLine($"URL dell'immagine della volpe: {imageUrl}");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nEccezione catturata!");
            Console.WriteLine("Messaggio: {0} ", e.Message);
        }
    }
}
