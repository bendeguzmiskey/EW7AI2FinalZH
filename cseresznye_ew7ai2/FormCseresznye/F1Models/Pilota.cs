using System;
using System.Collections.Generic;

namespace FormCseresznye.F1Models;

public partial class Pilota
{
    public int PilotaId { get; set; }

    public string Nev { get; set; } = null!;

    public string? Nemzetiseg { get; set; }

    public DateTime SzuletesiDatum { get; set; }

    public virtual ICollection<Eredmeny> Eredmeny { get; set; } = new List<Eredmeny>();
}
