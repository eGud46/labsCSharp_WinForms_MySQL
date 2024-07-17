using System;
using System.Collections.Generic;

namespace KursDBWinForms;

public partial class CriminalRecord
{
    public int Id { get; set; }

    public int IdPeople { get; set; }

    public string CriminalRecord1 { get; set; } = null!;

    public virtual Person IdPeopleNavigation { get; set; } = null!;
}
