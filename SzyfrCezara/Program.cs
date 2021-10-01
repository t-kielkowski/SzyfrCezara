using System;

namespace SzyfrCezara
{
    class Program
    {

        static char[] CezarSzyfrowanie(string text, int key)
        {
            char[] message = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                message[i] = (char)(text[i] + key);
            }

            return message;
        }

        static char[] CezarDeszyfrowanie(char[] text, int key)
        {
            char[] message = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                message[i] = (char)(text[i] - key);
            }

            return message;
        }

        static int Key(int count)
        {

            if (count > 0) Console.WriteLine("Podales nieprawidlowa wartosc klucza. Try again.");

            Console.WriteLine("Podaj wartosc klucza do zakodowania w przedziale wartości od -23 do 23");
            return int.Parse(Console.ReadLine());

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst do zakodowania");
            string tekst = Console.ReadLine();

            int klucz;
            int counter = 0;

            do
            {
                klucz = Key(counter);
                counter++;

            } while (klucz < -23 || klucz > 23);


            char[] message = CezarSzyfrowanie(tekst, klucz);
            Console.WriteLine("Szyfrowanie");

            for (int i = 0; i < tekst.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Deszyfrowanie");
            char[] message2 = CezarDeszyfrowanie(message, klucz);

            for (int i = 0; i < tekst.Length; i++)
            {
                Console.Write(message2[i]);
            }
        }
    }
}

