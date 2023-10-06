using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("4342342234","Modelo 1","111111111", 276);
Smartphone iphone = new Iphone("4342342234","Modelo 1","111111111", 276);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
