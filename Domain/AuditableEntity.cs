using System;

namespace Domain
{
    public abstract class AuditableEntity
    {
        public string CreatedBy { get; private set; }
        public DateTime CreatedDtm { get; private set; }
    }
}
