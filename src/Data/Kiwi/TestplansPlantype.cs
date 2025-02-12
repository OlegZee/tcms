﻿using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestplansPlantype
    {
        public TestplansPlantype()
        {
            Testplans = new HashSet<TestplansTestplan>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TestplansTestplan> Testplans { get; set; }
    }
}
