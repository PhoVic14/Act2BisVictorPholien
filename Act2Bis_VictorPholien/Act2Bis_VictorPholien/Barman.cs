using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Act2Bis_VictorPholien
{
    internal class Barman
    {
        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }
        }

        public Barman(string prenom)
        {
            _prenom = prenom;
        }

        public virtual bool Commander(Bouteille bouteille, Bar bar)
        {
            if (bar.AjouterBouteille())
            {
                Console.WriteLine($"{_prenom} a commandé une bouteille.");
                return true;
            }
            else
            {
                Console.WriteLine("Impossible de commander, le bar est vide.");
                return false;
            }
        }

        public virtual void Servir(Client client, Bar bar)
        {
            if (bar.Bouteilles.Length == 0)
            {
                Console.WriteLine("Impossible de servir, le bar est vide.");
                return;
            }

            Bouteille bouteille = bar.Bouteilles[bar.Bouteilles.Length - 1];
            bar.Bouteilles[bar.Bouteilles.Length - 1] = null;

            Console.WriteLine($"{_prenom} sert une bouteille à {client.Nom}.");
        }
    }
}