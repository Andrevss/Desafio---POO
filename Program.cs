using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei:"111222333444", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei:"444333222111", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Twitter");