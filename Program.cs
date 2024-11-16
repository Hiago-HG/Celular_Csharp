using DesafioPOO.Models;
Console.Write("\n");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone(numero: "8674-4521", modelo: "2020", imei: "1ph0n3", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.Write("\n");

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Iphone(numero: "3233-4584", modelo: "2021", imei: "n0k14", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Nubank");

Console.Write("\n");

Console.WriteLine($"Numero do Nokia : {nokia.Numero}");
nokia.Numero = "9535-6800";
Console.WriteLine($"Novo numero do Nokia : {nokia.Numero}");

