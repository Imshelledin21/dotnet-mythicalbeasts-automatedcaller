using System.Threading;
internal class Program
{

    private static void Main(string[] args)
    {

        var baseUrl = Environment.GetEnvironmentVariable("BASE_API_ENDPOINT");
        List<string> endpoints = new([
            "/mythicalbeasts",
            "/random"
        ]);

        Console.WriteLine("Hello, World!");
        Console.WriteLine("Let's query for some Mythical Beasts!");


        while (true)
        {
            var endpointCount = endpoints.Count;
            var rand = new Random();
            var num = rand.Next(0, endpointCount - 1);

            var endpoint = baseUrl + endpoints[num];

            Console.WriteLine("Sending request to: " + endpoint);

            var http = new HttpClient();
            http.GetAsync(endpoint).Wait();

            var sleepTimer = new Random();
            var sleepFor = sleepTimer.Next(0, 2000);

            Console.WriteLine("Sleeping for " + sleepFor + "ms");

            Thread.Sleep(sleepFor);
        }
    }
}

