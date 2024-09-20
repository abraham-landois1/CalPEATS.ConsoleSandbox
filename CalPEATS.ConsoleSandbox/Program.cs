// See https://aka.ms/new-console-template for more information

using CalPEATS.EfCore.Sandbox;

Console.WriteLine("Hello, World!");
UserDbContext context = new UserDbContext();
var version = context.Versions.OrderByDescending(v => v.Build).FirstOrDefault();
Console.WriteLine(version);