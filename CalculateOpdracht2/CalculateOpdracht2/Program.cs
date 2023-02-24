using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;


            //koop 2 controllers
            controllersInMandje += 2;

            //hij is in voorraad snel kopen!
            int ps5 = 0;

            //koop 1 ps5
            ps5++;

            //koop de games:

            int eldenRing = 0;

            int shantae = 0;

            int spongebob = 0;

            eldenRing++;
            shantae++;
            spongebob++;
            //hmmm weten we het zeker?
            Console.WriteLine("Weet je het zeker?");
            Console.WriteLine("Nee");

            //haal 1 game weg met -- of -= 1

            eldenRing--;

            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;


            double totaalControllerPrijs = 0;// controllersInMandje keer controllerPrijs
            totaalControllerPrijs = controllersInMandje * controllerPrijs;
            // game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)
            double totaalGamePrijs;
            totaalGamePrijs = eldenRing * gamePrijs + shantae * gamePrijs + spongebob * gamePrijs;


            double totaalPrijs = 0;// tel hier alles bij elkaar op
            totaalPrijs = totaalGamePrijs + totaalControllerPrijs + ps5Prijs;
            //er moet nu 759.95 staan

            Console.WriteLine("Het totale prijs is: " +totaalPrijs);
        }
    }
}