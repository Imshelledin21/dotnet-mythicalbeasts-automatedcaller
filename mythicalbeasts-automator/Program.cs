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


        while (true)
        {
            var endpointCount = endpoints.Count;
            var rand = new Random();
            var num = rand.Next(0, endpointCount - 1);

            var endpoint = baseUrl + endpoints[num];

            var http = new HttpClient();
            http.GetAsync(endpoint).Wait();

            var sleepTimer = new Random();
            var sleepFor = sleepTimer.Next(0, 2000);

            Thread.Sleep(sleepFor);
        }
    }
}

