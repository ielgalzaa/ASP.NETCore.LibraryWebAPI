using System;
using System.Collections.Generic;

namespace ASP.NETCore.LibraryWebAPI.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
