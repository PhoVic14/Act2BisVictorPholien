using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    public class Bouteille
    {
        private Liquide _contenu;
        private double _contenance;

        public Liquide Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        public double Contenance
        {
            get { return _contenance; }
            set { _contenance = value; }
        }

        public Bouteille(Liquide contenu, double contenance)
        {
            _contenu = contenu;
            _contenance = contenance;
        }

        public virtual bool Verser()
        {
            if (_contenance > 0)
            {
                Console.WriteLine($"Verse {_contenu}...");
                _contenance = 0; // Vide la bouteille
                return true;
            }
            else
            {
                Console.WriteLine("La bouteille est déjà vide.");
                return false;
            }
        }

        public virtual bool Jeter()
        {
            if (_contenance > 0)
            {
                Console.WriteLine("Jette la bouteille...");
                _contenance = 0; // Vide la bouteille
                return true;
            }
            else
            {
                Console.WriteLine("La bouteille est déjà vide.");
                return false;
            }
        }
    }
}
