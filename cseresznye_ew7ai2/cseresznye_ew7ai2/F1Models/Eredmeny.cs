using System;
using System.Collections.Generic;

namespace cseresznye_ew7ai2.F1Models;

public partial class Eredmeny
{
    public int EredmenyId { get; set; }

    public int PilotaId { get; set; }

    public int CsapatId { get; set; }

    public DateTime VersenyDatum { get; set; }

    public int Helyezes { get; set; }

    public virtual Csapat Csapat { get; set; } = null!;

    public virtual Pilota Pilota { get; set; } = null!;
}
