// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

Console.WriteLine("=== EXIBINDO DADOS INICIAIS ===");

Cliente c1 = new Cliente("Ana Silva", 251201822);
Cliente c2 = new Cliente("Carlos Souza", 954882522);

Doceiro d1 = new Doceiro("Chef Amanda", "Bolos");
Doceiro d2 = new Doceiro("Chef Lucas", "Brigadeiros");

Doce doce1 = new Doce("Brigadeiro de Pistache", 4.50m);
Doce doce2 = new Doce("Fatia de Red Velvet", 12.00m);

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(doce1);
Console.WriteLine(doce2);

Console.WriteLine("\n=== ALTERANDO VALORES VIA PROPERTIES ===");

c1.Telefone = 912345678;
doce1.Preco = 5.50m;

Console.WriteLine(c1);
Console.WriteLine(doce1);

Console.ReadLine();
