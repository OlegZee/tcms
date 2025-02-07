﻿using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class ManagementComponent
    {
        public ManagementComponent()
        {
            Testcasecomponents = new HashSet<TestCases.Testcasecomponent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? InitialOwnerId { get; set; }
        public int? InitialQaContactId { get; set; }
        public int ProductId { get; set; }

        public virtual AuthUser InitialOwner { get; set; }
        public virtual AuthUser InitialQaContact { get; set; }
        public virtual ManagementProduct Product { get; set; }
        public virtual ICollection<TestCases.Testcasecomponent> Testcasecomponents { get; set; }
    }
}
