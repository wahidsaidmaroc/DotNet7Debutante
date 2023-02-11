using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Produit
    {
        public int Id { get; set; }
        public string NomProduit { get; set; } = string.Empty;
    }

    public class ProduitWithCategorie
    {
        public int Id { get; set; }
        public int IdProduit { get; set; }
        private Produit? _Produit = new Produit();

        public Produit? Produit
        {
            get { return _Produit; }
            set { _Produit  = value; }
        }

        public int IdCategorie { get; set; }
    }
}
