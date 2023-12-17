using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "85923534", modelo: "G11 PLUS", imei: "123456-78-910111-2", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Iphone(numero: "97923233", modelo: "Iphone 13", imei: "131415-16-171819-2", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
