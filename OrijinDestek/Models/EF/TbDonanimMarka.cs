using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbDonanimMarka
{
    public int TbMarkaId { get; set; }

    public string? MarkaTanim { get; set; }

    public string? MarkaTip { get; set; }
}
