using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Models
{
    class Pizza
    {
        private string taille;
        private string type;

        public Pizza(string taille, string type)
        {
            this.taille = taille;
            this.type = type;
        }
    }
}
