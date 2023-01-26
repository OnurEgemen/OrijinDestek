using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbIpler
{
    public int TbIpId { get; set; }

    public string? IpAdres { get; set; }

    public string? IpNetwork { get; set; }

    public string? Aciklama { get; set; }

    public bool? IpDurumu { get; set; }

    public int? IpTipiId { get; set; }

    public int? CariId { get; set; }

    public int? SunucuId { get; set; }
}
