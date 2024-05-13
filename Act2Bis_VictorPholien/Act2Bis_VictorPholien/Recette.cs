using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    class Recettes
    {
        private Portion[] _ingredients;

        public Portion[] Ingredients
        {
            get
            {
                return _ingredients; // Utilise le champ privé ici au lieu de la propriété
            }
            set
            {
                _ingredients = value; // Utilise le champ privé ici au lieu de la propriété
            }
        }
    }
}