// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TProduit
{
    public int Id { get; set; }

    public string Description { get; set; }

    public string CodeProduit { get; set; }

    public decimal? PrixUnitaire { get; set; }

    public int? IdCategorie { get; set; }

    public virtual TCategorie IdCategorieNavigation { get; set; }

    public virtual ICollection<TDetailCommande> TDetailCommande { get; } = new List<TDetailCommande>();
}