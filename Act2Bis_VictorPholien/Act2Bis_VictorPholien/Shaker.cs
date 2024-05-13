using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    internal class Shaker
    {
        private double _contenanceMax;
        private Portion[] _contenu;
        private bool _propre;

        public double ContenanceMax
        {
            get { return _contenanceMax; }
        }

        public Portion[] Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        public bool Propre
        {
            get { return _propre; }
            set { _propre = value; }
        }

        public Shaker(double contenanceMax)
        {
            _contenanceMax = contenanceMax;
            _contenu = new Portion[10]; // Initialise le tableau de portions avec une taille de 10
            _propre = true; // Initialise le shaker propre
        }

        public double CalculQuantiteContenu()
        {
            double quantiteTotale = 0;
            foreach (Portion portion in _contenu)
            {
                if (portion != null)
                    quantiteTotale += portion.Quantite; // Assure-toi que c'est 'Quantite' et non 'Contenu'
            }
            return quantiteTotale;
        }

        public void AjouterPortion(Portion portion)
        {
            if (CalculQuantiteContenu() + portion.Quantite > _contenanceMax)
            {
                Console.WriteLine("Pas assez de place pour ajouter cette portion!");
                return;
            }
            for (int i = 0; i < _contenu.Length; i++)
            {
                if (_contenu[i] == null)
                {
                    _contenu[i] = portion;
                    break;
                }
            }
        }

        public string MelangerContenu()
        {
            if (!_propre)
                return "Impossible de mélanger le contenu, le shaker n'est pas propre.";

            return "Contenu mélangé avec succès.";
        }

        public void Vider()
        {
            _contenu = new Portion[10]; // Réinitialise le contenu du shaker
            _propre = false;
        }

        public string Laver()
        {
            _propre = true; // Marque le shaker comme propre
            return "Shaker lavé avec succès.";
        }
    }
}