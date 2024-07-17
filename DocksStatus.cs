using System;
using System.Collections.Generic;

namespace KursDBWinForms;

public partial class DocksStatus
{
    public int IdDocks { get; set; }

    public string Executor { get; set; } = null!;

    public DateOnly Deadline { get; set; }

    public string Responsible { get; set; } = null!;

    public sbyte? Complete { get; set; }

    public virtual Dock IdDocksNavigation { get; set; } = null!;
}
