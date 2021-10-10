using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Models
{
    class Commis : Effectif
    {
        private string nomCommis;

        public Commis(string nomCommis, int num)
        {
            this.nomCommis = nomCommis;
            this.num = num;
        }

        }
    }
