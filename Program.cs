using DesafioPOO.Models;
using System;

//Realizando testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Tijolão", imei: "01233344566", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("Instalação Concluída!");

Console.WriteLine("\n");

Console.WriteLine("Teste no Iphone");
Smartphone iphone = new Iphone(numero: "1233333333", modelo: "15Pro", imei: "00033344566", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine("Instalação Concluída!");