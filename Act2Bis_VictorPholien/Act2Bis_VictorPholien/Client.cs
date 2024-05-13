using System;

namespace Act2Bis_VictorPholien
{
    internal class Client
    {
        public string Nom { get; private set; }

        public Client(string nom)
        {
            Nom = nom;
        }
    }
}