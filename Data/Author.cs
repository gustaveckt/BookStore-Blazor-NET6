﻿using System;
using System.Collections.Generic;

namespace BookStore.Api.Data;

public partial class Author
{
    public int Id { get; set; }

    public string? FistName { get; set; }

    public string? LastName { get; set; }

    public string? Bio { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
