// See https://aka.ms/new-console-template for more information
using homework_2;

Lista lista = new Lista();

lista.Dodaj(10);
lista.Dodaj(20);
lista.Dodaj(30);
lista.Dodaj(40);
lista.Dodaj(40);
lista.Dodaj(40);
lista.Dodaj(10);
lista.Dodaj(40);
lista.Dodaj(50);
lista.Dodaj(40);
lista.Dodaj(40);

lista.Usun(10);
lista.Usun(10);

lista.Usun(40, true);

foreach (var i in lista) {
    Console.WriteLine(i.wartosc);
}

Console.WriteLine(lista.Dlugosc);