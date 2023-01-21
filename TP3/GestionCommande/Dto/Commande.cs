using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public decimal TotalCommande { get; set; }
    }
}
