using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbKodtip
{
    public int TbKodtipId { get; set; }

    public int? Kod { get; set; }

    public string? Tanim { get; set; }
}
