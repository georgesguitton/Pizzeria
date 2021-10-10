using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Models
{
    class Commande
    {
        private int numero;
        private string heure;
        private string date;
        private string nomClient;
        private string nomCommis;
        private string etat;
        private Boolean payee;
        private double prix;
        private int numLivreur;

        public Commande(int numero, string heure, string date, string nomClient, string nomCommis, string etat, Boolean payee, double prix, int numLivreur)
        {
            this.numero = numero;
            this.heure = heure;
            this.date = date;
            this.nomClient = nomClient;
            this.nomCommis = nomCommis;
            this.etat = etat;
            this.payee = payee;
            this.prix = prix;
            this.numLivreur = numLivreur;
        }
    }
}
