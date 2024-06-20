using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

// Classe che rappresenta la risposta JSON
public class FoxImage
{
    public string Image { get; set; }
    public string Link { get; set; }
}

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

            // Deserializzare il JSON nella classe FoxImage
            FoxImage foxImage = JsonSerializer.Deserialize<FoxImage>(responseBody);

            // Stampare l'URL dell'immagine
            Console.WriteLine($"URL dell'immagine della volpe: {foxImage.Image}");
            // Stampare il link
            Console.WriteLine($"Link: {foxImage.Link}");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nEccezione catturata!");
            Console.WriteLine("Messaggio: {0} ", e.Message);
        }
    }
}
