﻿using System;
using System.Collections.Generic;

namespace Esercizio_MVC_Core_DB.Models.DB;

public partial class Staff
{
    public int StaffId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public byte Active { get; set; }

    public int StoreId { get; set; }

    public int? ManagerId { get; set; }

    public virtual ICollection<Staff> InverseManager { get; set; } = new List<Staff>();

    public virtual Staff? Manager { get; set; }
}
