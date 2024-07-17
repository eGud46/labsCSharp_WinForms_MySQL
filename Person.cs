using System;
using System.Collections.Generic;

namespace KursDBWinForms;

public partial class Person
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public string Biography { get; set; } = null!;

    public byte[]? Photo { get; set; }

    public byte[]? Print { get; set; }

    public virtual ICollection<AffairsPerson> AffairsPeople { get; set; } = new List<AffairsPerson>();

    public virtual ICollection<Alias> Aliases { get; set; } = new List<Alias>();

    public virtual ICollection<CriminalRecord> CriminalRecords { get; set; } = new List<CriminalRecord>();
}
