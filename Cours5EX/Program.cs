using System;
using static System.Console;

namespace Cours5EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Voiture voiture = new("Toyota");
            voiture.Accelere(20);
            WriteLine("SPEED : {0}", voiture.RetournerVitesse());
            voiture.Ralentie(10);
            WriteLine("SPEED : {0}", voiture.RetournerVitesse());
            voiture.Arret();
            WriteLine("SPEED : {0}", voiture.RetournerVitesse());
            voiture.Accelere(40);
            WriteLine("SPEED : {0}", voiture.RetournerVitesse());
            voiture.Turbo();
            WriteLine("SPEED : {0}", voiture.RetournerVitesse());
            voiture.POLICEZONESCOLAIRE();
            WriteLine("SPEED : {0}", voiture.RetournerVitesse());
            voiture.Accelere(150);
            WriteLine("SPEED : {0}",voiture.RetournerVitesse());
            voiture.POLICEAUTOROUTE();
            WriteLine("SPEED : {0}", voiture.RetournerVitesse());
            WriteLine("BRAND : {0}",voiture.RetournerBrand());
        }
    }
}
