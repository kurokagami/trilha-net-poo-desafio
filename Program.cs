using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia(Numero: "11 98763-5543", Modelo: "Nokia C210", IMEI: "232041557839290", Memoria: 32);
Iphone i1 = new Iphone(Numero: "47 96785-9087", Modelo: "Iphone 13", IMEI: "291026750518837", Memoria: 128);

n1.ReceberLigacao();
n1.Ligar();
n1.InstalarAplicativo("Telegram");
n1.Informações();

i1.ReceberLigacao();
i1.Ligar();
i1.InstalarAplicativo("Telegram");
i1.Informações();