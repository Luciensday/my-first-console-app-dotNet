﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}");
Console.Write($"{Environment.NewLine}Press any key to exit..."); 
Console.ReadKey(true); 