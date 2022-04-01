using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cours5EX
{
    public class Voiture
    {
        private uint vitesse;
        private string brand;

        public Voiture()
        {
            this.vitesse = 0;
        }

        public Voiture(uint vitesse) 
        {
            this.vitesse = vitesse;
        }

        public Voiture(string brand)
        {
            this.brand = brand;
        }

        public void Accelere(uint Champignon)
        {
            vitesse += Champignon;
        }

        public void Ralentie(uint brake)
        { 
        vitesse -= brake;
        }

        public void Arret()
        { 
        vitesse = 0;
        }

        public void Turbo()
        {
            vitesse += 1000;
        }

        public void POLICEAUTOROUTE()
        {
            vitesse = 95;
        }

        public void POLICEZONESCOLAIRE()
        {
            vitesse = 29;
        }

        public uint RetournerVitesse()
        { 
            return vitesse;
        }

        public string RetournerBrand()
        { 
            return brand;
        }
    }
}
