using System;
using System.Collections.Generic;

namespace KursDBWinForms;

public partial class DocksFile
{
    public int Id { get; set; }

    public int IdDocks { get; set; }

    public byte[] File { get; set; } = null!;

    public virtual Dock IdDocksNavigation { get; set; } = null!;
}
