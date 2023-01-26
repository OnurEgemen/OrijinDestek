using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbCariUser
{
    public int TbCariUserId { get; set; }

    public string UserName { get; set; } = null!;
}
