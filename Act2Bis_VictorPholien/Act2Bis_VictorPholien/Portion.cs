using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    class Portion
    {
        private Liquide _contenu;
        private double _quantite;  // Quantité du liquide en centilitres

        public Portion(Liquide contenu, double quantite)
        {
            _contenu = contenu;
            _quantite = quantite;
        }

        public Liquide Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        public double Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }

        public bool TesterPortion()
        {
            // Vérifie si la quantité de la portion est supérieure à zéro
            return _quantite > 0;
        }
    }
}