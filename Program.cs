using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99-99999-9999", modelo: "Modelo 1", imei: "A1B2C3D4", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine($"Fim do teste Nokia {nokia.Numero}");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "88-88888-8888", modelo: "Iphone 15 Pro", imei: "0000", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine($"Fim do teste Iphone {iphone.Numero}");