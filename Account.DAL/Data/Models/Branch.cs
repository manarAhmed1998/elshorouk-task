using System;
using System.Collections.Generic;

namespace Account.DAL.Data.Models;

public partial class Branch
{
    public int Id { get; set; }

    public string BranchName { get; set; } = null!;

    public int CityId { get; set; }

    public virtual ICollection<Cashier> Cashiers { get; set; } = new List<Cashier>();

    public virtual City City { get; set; } = null!;

    public virtual ICollection<InvoiceHeader> InvoiceHeaders { get; set; } = new List<InvoiceHeader>();
}
