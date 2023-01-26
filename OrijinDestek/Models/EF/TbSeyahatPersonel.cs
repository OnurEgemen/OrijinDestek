using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbSeyahatPersonel
{
    public int TbSeyahatPersonelId { get; set; }

    public int? SprKullaniciId { get; set; }

    public string? SprAciklama { get; set; }

    public int? SprSeyahatId { get; set; }
}
