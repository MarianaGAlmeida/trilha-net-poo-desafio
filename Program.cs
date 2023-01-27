using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234-5678", modelo: "nokia-tal", imei: "12345678", memoria: 10);
//Smartphone nokia2 =  new Nokia(numero: "ggaerg", modelo: "dsfks", imei: "sdgaerg", memoria: 10);


nokia.Numero = "novo_numero";
Console.WriteLine(nokia.Numero);
nokia.InstalarAplicativo("Nome_aplicativo");
nokia.Ligar();


