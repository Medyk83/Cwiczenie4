using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 7, 3, 9, 4, 9, 2 };

        int najmniejszy = tablica[0];
        int najwiekszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
                najmniejszy = tablica[i];

            if (tablica[i] > najwiekszy)
                najwiekszy = tablica[i];
        }

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + najwiekszy);
        Console.ReadLine();
    }
}
