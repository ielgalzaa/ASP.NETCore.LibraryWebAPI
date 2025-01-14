using System;
using System.Collections.Generic;

namespace ASP.NETCore.LibraryWebAPI.Models;

public partial class Book
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Isbn { get; set; }

    public int PublishYear { get; set; }

    public virtual User User { get; set; } = null!;
}
