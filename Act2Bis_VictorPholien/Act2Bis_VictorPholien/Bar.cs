using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    internal class Bar
    {
        private Bouteille[] _bouteilles;
        private int _index; // Pour suivre le nombre de bouteilles dans le bar

     
        public Bouteille[] Bouteilles
        {
            get
            {
                return _bouteilles;
            }
            set
            {
                _bouteilles = value;
            }
        }


        public virtual bool PrendreBouteille(Bouteille bouteille)
        {
            // Vérifie si le tableau est plein
            if (_index >= _bouteilles.Length)
            {
                Console.WriteLine("Le bar est plein, impossible d'ajouter une autre bouteille.");
                return false;
            }

            // Ajoute la bouteille au tableau
            _bouteilles[_index] = bouteille;
            _index++; // Incrémente l'index

            Console.WriteLine("Bouteille ajoutée avec succès au bar.");
            return true;
        }


        public virtual bool AjouterBouteille()
        {
            // Vérifie si le tableau est vide
            if (_index == 0)
            {
                Console.WriteLine("Le bar est vide, impossible de prendre une bouteille.");
                return false;
            }

            // Retire la dernière bouteille ajoutée au tableau
            _index--;

            Console.WriteLine("Bouteille retirée avec succès du bar.");
            return true;
        }


        public virtual string AfficherInventairebar()
        {
            string info = "L'inventaire du bar : \n";
            for (int i = 0; i < _index; i++)
            {
                info += $"{i + 1}. {_bouteilles[i]}\n"; // Affiche chaque bouteille
            }
            return info;
        }
    }
}
