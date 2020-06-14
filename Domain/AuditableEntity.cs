using System;

namespace Domain
{
    public abstract class AuditableEntity
    {
        public int Id { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime CreatedDtm { get; private set; }
    }
}
