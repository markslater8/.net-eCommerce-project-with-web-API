﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class AppUser : User
    {
        public AppUser()
        {
            AppUserAppOperationClaims = new HashSet<AppUserAppOperationClaim>();
        }
        public Guid RefreshToken { get; set; }
        public virtual ICollection<AppUserAppOperationClaim> AppUserAppOperationClaims { get; set; }
    }
}