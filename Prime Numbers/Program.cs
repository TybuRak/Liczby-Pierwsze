using System;
using System.Threading;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bierze ilość działań do zrobienia
            Console.Write("Podaj ilość liczb do sprawdzenia:");
            string ilosc = Console.ReadLine();
            int iloscInt = int.Parse(ilosc);
            string[] wyniki = new string[iloscInt];
            for (int i = 0; i < iloscInt; i++)
            {
                //Pobiera liczbę
                Console.Write("Podaj liczbę:");
                string liczba = Console.ReadLine();
                int liczbaInt = int.Parse(liczba);

                //Sprawdzanie czy liczba jest pierwsza
                bool isPrime()
                {
                    //Sprawdza czy liczbaInt == 1
                    if (liczbaInt == 1)
                    {
                        return false;
                    }
                    
                    //Sprawdza czy liczba dzieli się przez liczbę inną niż 1 lub ona sama
                    for (int j = 2; j < liczbaInt; j++)
                    {
                        if (liczbaInt % j == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }

                //Wprowadzanie odpowiedzi do array'u
                if (isPrime() == true)
                {
                    wyniki[i] = "TAK";
                }
                else
                {
                    wyniki[i] = "NIE";
                }
            }
            for (int k = 0; k < iloscInt; k++)
            {
                Console.WriteLine(wyniki[k]);
            }
        }
    }
}