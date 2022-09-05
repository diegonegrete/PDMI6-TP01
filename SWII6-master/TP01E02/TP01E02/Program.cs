// See https://aka.ms/new-console-template for more information
//using ExemploAula02;
using Microsoft.AspNetCore.Hosting;
using TP01E02;
using TP01E02.Repositorio;

BookCSV bookCSV = new BookCSV();

IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
host.Run();
