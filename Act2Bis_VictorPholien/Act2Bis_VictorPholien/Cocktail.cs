using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Act2Bis_VictorPholien
{
    internal class Ingredient
    {
        public string Nom { get; set; }
        public double Quantite { get; set; } // Quantity in centiliters

        public Ingredient(string nom, double quantite)
        {
            Nom = nom;
            Quantite = quantite;
        }
    }

    internal class Recette
    {
        public List<Ingredient> Ingredients { get; private set; } = new List<Ingredient>();

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }

    internal class Cocktail
    {
        private string _nom;
        private double _contenance;
        private Recette _recetteCocktail;

        public string Nom => _nom;

        public double Contenance
        {
            get { return _contenance; }
            set { _contenance = value; }
        }

        public Cocktail(string nom, Recette recetteCocktail)
        {
            _nom = nom;
            _recetteCocktail = recetteCocktail;
            UpdateContenance();
        }

        private void UpdateContenance()
        {
            _contenance = 0;
            foreach (Ingredient ingredient in _recetteCocktail.Ingredients)
            {
                _contenance += ingredient.Quantite;
            }
        }

        public double ContenanceActuelle()
        {
            return _contenance;
        }

        public string AfficherRecette()
        {
            var recette = $"Recette du cocktail {_nom} :\n";
            foreach (Ingredient ingredient in _recetteCocktail.Ingredients)
            {
                recette += $"{ingredient.Nom} : {ingredient.Quantite} cl\n";
            }
            return recette;
        }
    }
}