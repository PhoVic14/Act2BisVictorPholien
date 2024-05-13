using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    class Cave
    {
        private Dictionary<string, double> _stockIngredients = new Dictionary<string, double>();

        // Initialisation avec quelques ingrédients pour l'exemple
        public Cave()
        {
            _stockIngredients["Rhum"] = 5000;  // 5000 cl de Rhum
            _stockIngredients["Tequila"] = 3000;  // 3000 cl de Tequila
                                                  // Ajoute d'autres ingrédients selon tes besoins
        }

        public bool VerifierDisponibilite(string nomIngredient, double quantiteRequise)
        {
            if (_stockIngredients.ContainsKey(nomIngredient))
            {
                return _stockIngredients[nomIngredient] >= quantiteRequise;
            }
            return false;
        }

        // Méthode pour utiliser l'ingrédient (diminuer le stock)
        public void UtiliserIngredient(string nomIngredient, double quantiteUtilisee)
        {
            if (_stockIngredients.ContainsKey(nomIngredient) && _stockIngredients[nomIngredient] >= quantiteUtilisee)
            {
                _stockIngredients[nomIngredient] -= quantiteUtilisee;
            }
            else
            {
                Console.WriteLine($"Pas assez de {nomIngredient} disponible.");
            }
        }
    }
}
