﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ApplicationRoleClaim : IdentityRoleClaim<string>
    {
        public bool check { get; set; }
    }
}
