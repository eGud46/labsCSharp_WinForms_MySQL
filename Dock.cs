using System;
using System.Collections.Generic;

namespace KursDBWinForms;

public partial class Dock
{
    public int Id { get; set; }

    public string Header { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string ByWho { get; set; } = null!;

    public virtual ICollection<Affair> Affairs { get; set; } = new List<Affair>();

    public virtual ICollection<DocksFile> DocksFiles { get; set; } = new List<DocksFile>();

    public virtual DocksStatus? DocksStatus { get; set; }
}
