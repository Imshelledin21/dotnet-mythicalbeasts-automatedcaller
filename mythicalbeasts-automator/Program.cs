using System.Threading;
internal class Program
{

    private static void Main(string[] args)
    {

        var baseUrl = "http://mythicalbeast.mythics.svc.cluster.local";
        List<string> endpoints = new([
            "/mythicalbeasts"
        ]);

        Console.WriteLine("Hello, World!");


        while (true)
        {
            Console.WriteLine(baseUrl + endpoints[0]);

            Thread.Sleep(1000);
        }
    }
}

