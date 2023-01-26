using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbDestekKonu
{
    public int TbDestekKonuId { get; set; }

    public string? TbDestekKonuBaslik { get; set; }

    public string? TbDestekKonuIcerik { get; set; }
}
