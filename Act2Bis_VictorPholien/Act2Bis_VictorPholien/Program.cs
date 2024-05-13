using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Bis_VictorPholien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialisation du bar, de la cave, et du personnel
            Bar bar = new Bar();
            Cave cave = new Cave();
            Barman victor = new Barman("Victor");
            Shaker shaker = new Shaker(500);  // Capacité maximale du shaker en millilitres

            // Création de quelques recettes
            var recettes = new Dictionary<string, Recette>
            {
                ["Mojito"] = CreerMojito(),
                ["Margarita"] = CreerMargarita(),
                ["Espresso Martini"] = CreerEspressoMartini(),
                ["Cosmopolitan"] = CreerCosmopolitan(),
                ["Manhattan"] = CreerManhattan(),
            };

            // Interaction avec le client
            Console.WriteLine("Bonjour, je suis Victor. Voici les cocktails que je peux vous préparer aujourd'hui:");
            foreach (var recette in recettes.Keys)
            {
                Console.WriteLine("- " + recette);
            }

            Console.WriteLine("Veuillez taper le nom du cocktail que vous souhaitez boire.");
            string choixClient = Console.ReadLine().Trim();

            // Réponse du serveur et vérification de la disponibilité
            if (recettes.ContainsKey(choixClient))
            {
                Console.WriteLine($"Un instant, je vérifie si nous pouvons préparer un {choixClient} pour vous.");
                Recette recetteChoisie = recettes[choixClient];

                bool peutPreparer = true;
                foreach (var ingredient in recetteChoisie.Ingredients)
                {
                    if (!cave.VerifierDisponibilite(ingredient.Nom, ingredient.Quantite))
                    {
                        peutPreparer = false;
                        Console.WriteLine($"Désolé, nous n'avons plus assez de {ingredient.Nom}.");
                        break;
                    }
                }

                if (peutPreparer)
                {
                    // Préparation de la boisson
                    foreach (var ingredient in recetteChoisie.Ingredients)
                    {
                        cave.UtiliserIngredient(ingredient.Nom, ingredient.Quantite);
                    }
                    Console.WriteLine($"Voici votre {choixClient}, préparé avec soin. Profitez-en !");
                }
            }
            else
            {
                Console.WriteLine("Désolé, ce cocktail n'est pas disponible. Veuillez choisir parmi la liste donnée ci-dessus.");
            }
        }

        static Recette CreerMojito()
        {
            Recette mojito = new Recette();
            mojito.AddIngredient(new Ingredient("Rhum", 40));
            mojito.AddIngredient(new Ingredient("Eau gazeuse", 60));
            mojito.AddIngredient(new Ingredient("Menthe", 10));
            mojito.AddIngredient(new Ingredient("Citron vert", 20));
            mojito.AddIngredient(new Ingredient("Sucre de canne", 10));
            return mojito;
        }

        static Recette CreerMargarita()
        {
            Recette margarita = new Recette();
            margarita.AddIngredient(new Ingredient("Tequila", 50));
            margarita.AddIngredient(new Ingredient("Jus de citron vert", 30));
            margarita.AddIngredient(new Ingredient("Triple sec", 20));
            margarita.AddIngredient(new Ingredient("Sel", 1));
            return margarita;
        }

        static Recette CreerEspressoMartini()
        {
            Recette espressoMartini = new Recette();
            espressoMartini.AddIngredient(new Ingredient("Vodka", 50));
            espressoMartini.AddIngredient(new Ingredient("Espresso", 30));
            espressoMartini.AddIngredient(new Ingredient("Liqueur de café", 10));
            espressoMartini.AddIngredient(new Ingredient("Sirop de sucre", 5));
            return espressoMartini;
        }

        static Recette CreerCosmopolitan()
        {
            Recette cosmopolitan = new Recette();
            cosmopolitan.AddIngredient(new Ingredient("Vodka", 40));
            cosmopolitan.AddIngredient(new Ingredient("Triple sec", 20));
            cosmopolitan.AddIngredient(new Ingredient("Jus de cranberry", 30));
            cosmopolitan.AddIngredient(new Ingredient("Jus de citron vert", 10));
            return cosmopolitan;
        }

        static Recette CreerManhattan()
        {
            Recette manhattan = new Recette();
            manhattan.AddIngredient(new Ingredient("Whisky de seigle", 50));
            manhattan.AddIngredient(new Ingredient("Vermouth rouge", 20));
            manhattan.AddIngredient(new Ingredient("Bitters Angostura", 0.1));  
            return manhattan;
        }
    }
}