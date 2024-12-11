using System;
using System.Collections.Generic;

namespace cseresznye_ew7ai2.F1Models;

public partial class Csapat
{
    public int CsapatId { get; set; }

    public string Nev { get; set; } = null!;

    public int AlapitasiEv { get; set; }

    public string? Szponzor { get; set; }

    public virtual ICollection<Eredmeny> Eredmeny { get; set; } = new List<Eredmeny>();
}
