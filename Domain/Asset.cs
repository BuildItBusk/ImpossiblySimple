using System;

namespace Domain
{
    public class Asset : AuditableEntity
    {
        // EF Core constructor
        private Asset() { }

        public Asset(DateTime firstRegistration)
        {
            FirstRegistration = firstRegistration != default ? firstRegistration : throw new ArgumentException("First registration date cannot be default date value.");
        }

        public AgreementStatus Status { get; private set; }

        public DateTime FirstRegistration { get; private set; }
    }
}