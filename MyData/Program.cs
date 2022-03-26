// See https://aka.ms/new-console-template for more information

using System.Net.Mail;
using CheckData;

IMain main = new Main();
var content = "MauricioJunior82*&";
var result = main.IsURL("2098slskjslk");

Console.WriteLine("Is URL? " + result);

var letters = main.ReturnLetters(content);

Console.WriteLine("Letters: " + letters);

var numbers = main.ReturnNumber(content);

Console.WriteLine($"Numbers: {numbers}");

var lowercase = main.ReturnLowerCase(content);

Console.WriteLine($"Lower: {lowercase}");