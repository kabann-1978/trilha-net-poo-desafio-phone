using System.ComponentModel;
using DesafioPOO.Models;

// Testando as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456", "Modelo 10c", "1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Evernote");


Console.WriteLine("Smarthphone Iphone:");
Iphone iphone = new Iphone( "489654", "14 pro", "333333333", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");