using System;
using System.Collections.Generic;

namespace KursDBWinForms;

public partial class AffairsPerson
{
    public int Id { get; set; }

    public int IdPeople { get; set; }

    public int IdAffairs { get; set; }

    public virtual Affair IdAffairsNavigation { get; set; } = null!;

    public virtual Person IdPeopleNavigation { get; set; } = null!;
}
