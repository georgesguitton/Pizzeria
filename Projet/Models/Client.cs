using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Models
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        private int telephone;
        private string datePremiereCommande;


        public Client(string nom, string prenom, string adresse, int telephone, string datePremiereCommande)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.telephone = telephone;
            this.datePremiereCommande = datePremiereCommande;  
        }



    }
}
