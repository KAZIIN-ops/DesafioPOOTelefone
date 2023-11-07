using System.ComponentModel.DataAnnotations;
using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia s1= new Nokia(numero:"12",modelo:"galaxy",imei:"123",memoria:24);
s1.ReceberLigacao();
s1.InstalarAplicativo("AppContext");
Iphone s2 = new Iphone(numero:"123",modelo:"ai",imei:"123",memoria:25);
s2.Ligar();
s2.ReceberLigacao();
s2.InstalarAplicativo("Android kkkk");


