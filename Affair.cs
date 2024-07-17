using System;
using System.Collections.Generic;

namespace KursDBWinForms;

public partial class Affair
{
    public int Id { get; set; }

    public int IdDocks { get; set; }

    public sbyte? CriminalOrNot { get; set; }

    public string Responsible { get; set; } = null!;

    public virtual ICollection<AffairsPerson> AffairsPeople { get; set; } = new List<AffairsPerson>();

    public virtual Dock IdDocksNavigation { get; set; } = null!;
}
