using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Models
{
    class Boisson
    {
        private string nomBoisson;
        private double prix;

        public Boisson(string nomBoisson, double prix)
        {
            this.nomBoisson = nomBoisson;
            this.prix = prix;
        }
    }
}
