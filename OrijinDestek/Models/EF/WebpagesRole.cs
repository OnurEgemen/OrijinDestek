﻿using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class WebpagesRole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<UserProfile> Users { get; } = new List<UserProfile>();
}
