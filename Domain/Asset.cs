using System;

namespace Domain
{
    public class Asset : AuditableEntity
    {
        public Asset(DateTime firstRegistration)
        {
            FirstRegistration = firstRegistration != default ? firstRegistration : throw new ArgumentException("First registration date cannot be default date value.");
        }

        public int Id { get; private set; }

        public AgreementStatus Status { get; private set; }

        public DateTime FirstRegistration { get; private set; }
    }
}