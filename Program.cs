using System;

namespace MappimiseRakendus
{
    class Program
    {
        static void Main(string[] args)
        {
            Töötaja töötaja1 = new Töötaja
            {
                Nimi = "John Doe",
                Vanus = 30,
                Töökoht = "Arendaja"
            };

            Töötaja töötaja2 = new Töötaja
            {
                Nimi = "Jane Smith",
                Vanus = 25,
                Töökoht = "Disainer"
            };

            Klient klient1 = Mappija.MapiTöötajaKlientiks(töötaja1);
            Klient klient2 = Mappija.MapiTöötajaKlientiks(töötaja2);

            Console.WriteLine("Klient 1:");
            Console.WriteLine("Nimi: " + klient1.Nimi);
            Console.WriteLine("Vanus: " + klient1.Vanus);
            Console.WriteLine("Kasutajanimi: " + klient1.Kasutajanimi);
            Console.WriteLine();

            Console.WriteLine("Klient 2:");
            Console.WriteLine("Nimi: " + klient2.Nimi);
            Console.WriteLine("Vanus: " + klient2.Vanus);
            Console.WriteLine("Kasutajanimi: " + klient2.Kasutajanimi);

            Console.ReadLine();
        }
    }

    class Töötaja
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Töökoht { get; set; }
    }

    class Klient
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Kasutajanimi { get; set; }
    }

    static class Mappija
    {
        public static Klient MapiTöötajaKlientiks(Töötaja töötaja)
        {
            Klient klient = new Klient
            {
                Nimi = töötaja.Nimi,
                Vanus = töötaja.Vanus,
                Kasutajanimi = GenereeriKasutajanimi(töötaja.Nimi)
            };

            return klient;
        }

        private static string GenereeriKasutajanimi(string nimi)
        {
          
            string[] osad = nimi.Split(' ');
            string eesnimi = osad[0];
            string perenimi = osad[1];
            string kasutajanimi = $"{eesnimi.ToLower()}.{perenimi.ToLower()}";

            return kasutajanimi;
        }
    }
}
