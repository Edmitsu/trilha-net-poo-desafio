using DesafioPOO.Models;

Console.WriteLine("--- Teste Nokia ---");
Nokia nokia = new Nokia(numero: "11999999999", imei: "123456789012345", modelo: "Nokia 3310", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

// Testes com a classe Iphone
Console.WriteLine("\n--- Teste iPhone ---");
Iphone iphone = new Iphone(numero: "11988888888", imei: "987654321098765", modelo: "iPhone 13", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
