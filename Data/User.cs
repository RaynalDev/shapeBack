﻿using System;
using System.Collections.Generic;

namespace portrait.Data;

public partial class User
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
