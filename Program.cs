using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphoneGabriel = new Iphone("910474328","Iphone 12","123123kkk12asdg12",128);
iphoneGabriel.InstalarAplicativo("WhatsApp");
iphoneGabriel.Ligar();
iphoneGabriel.ReceberLigacao();


Console.WriteLine("\n");


Smartphone nokiaGabriel = new Nokia("910471771","Nokia tijolao","11223344HHHH22",64);
nokiaGabriel.InstalarAplicativo("Telegram");
nokiaGabriel.Ligar();
nokiaGabriel.ReceberLigacao();