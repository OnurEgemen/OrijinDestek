using System;
using System.Collections.Generic;

namespace OrijinDestek.Models.EF;

public partial class TbMail
{
    public int TbMailId { get; set; }

    public string? MailKonu { get; set; }

    public string? MailAciklama { get; set; }

    public int? MailTip { get; set; }
}
