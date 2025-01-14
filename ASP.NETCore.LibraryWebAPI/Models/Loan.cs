using System;
using System.Collections.Generic;

namespace ASP.NETCore.LibraryWebAPI.Models;

public partial class Loan
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int BookId { get; set; }

    public DateTime LoanDate { get; set; }
}
