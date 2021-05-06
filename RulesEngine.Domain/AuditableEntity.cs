//-----------------------------------------------------------------------
// <copyright file="AutoRoutingFunction.cs" company="SBR">
// Copyright (c) SBR. All rights reserved.
// </copyright>
// <summary> Rules Engine </summary>
//-----------------------------------------------------------------------

namespace RulesEngine.Domain
{
    using System;
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
