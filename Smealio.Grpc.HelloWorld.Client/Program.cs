using Grpc.Net.Client;
using Smealio.Grpc.HelloWorld.App1;
using System;
using System.Threading.Tasks;

namespace Smealio.Grpc.HelloWorld.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var app1Service = GrpcChannel.ForAddress("");
            var client = new Greeter.GreeterClient(app1Service);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Adam" });

           
        }
    }
}
