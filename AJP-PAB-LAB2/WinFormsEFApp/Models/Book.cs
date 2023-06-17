using System;
using System.Collections.Generic;

namespace WinFormsEFApp.Models;

public partial class Book
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Pages { get; set; }

    public int? AuthorId { get; set; }
}
