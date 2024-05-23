using DesafioPOO.Models;

Iphone iphone = new Iphone("(61)96543-0912", "Iphone11", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
Nokia nokia = new Nokia("(61)98543-0956", "Motorola 34", 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
// Implementado!