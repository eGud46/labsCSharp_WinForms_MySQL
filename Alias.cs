using System;
using System.Collections.Generic;

namespace KursDBWinForms;

public partial class Alias
{
    public int Id { get; set; }

    public int IdPeople { get; set; }

    public string Alias1 { get; set; } = null!;

    public virtual Person IdPeopleNavigation { get; set; } = null!;
}
