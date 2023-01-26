using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbIl
{
    public int TbIlId { get; set; }

    public string? AlanKod { get; set; }

    public string? IlTanim { get; set; }

    public string? Ulke { get; set; }

    public string? TelKod { get; set; }
}
