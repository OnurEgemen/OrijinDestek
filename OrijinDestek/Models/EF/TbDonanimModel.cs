﻿using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbDonanimModel
{
    public int TbModelId { get; set; }

    public string? ModelTanim { get; set; }

    public int? MarkaId { get; set; }
}
