using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbPersonelIzinYil
{
    public int TbPersonelIzinYilId { get; set; }

    public int? Fark { get; set; }

    public int? CariId { get; set; }
}
