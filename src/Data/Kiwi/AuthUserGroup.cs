﻿using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class AuthUserGroup
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }

        public virtual AuthGroup Group { get; set; }
        public virtual AuthUser User { get; set; }
    }
}
