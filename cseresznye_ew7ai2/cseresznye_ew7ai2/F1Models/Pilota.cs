using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace cseresznye_ew7ai2.F1Models;

public partial class Pilota
{
    public int PilotaId { get; set; }

    public string Nev { get; set; } = null!;

    public string? Nemzetiseg { get; set; }

    public DateTime SzuletesiDatum { get; set; }

    [JsonIgnore]

    public virtual ICollection<Eredmeny> Eredmeny { get; set; } = new List<Eredmeny>();
}
