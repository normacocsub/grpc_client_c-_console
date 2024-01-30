// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using test;

Console.WriteLine("Hello, World!");

using var channel = GrpcChannel.ForAddress("https://localhost:7193");
var client = new User.UserClient(channel);


var request = new UserRequest
{
    UserName = "Prueba",
    Password = "Hola123",
    Email = "test@gmail.com",
    FirstName = "Fernando",
    LastName = "Vega"
};

var response = client.CreateUser(request);

Console.WriteLine("Test: " + response.Message);