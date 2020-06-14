using System;

namespace Domain
{
    public class Agreement : AuditableEntity
    {
        // EF Core constructor
        private Agreement() { }

        public Agreement(Asset asset)
        {
            Asset = asset ?? throw new ArgumentNullException(nameof(asset));
        }

        public int AgreementNumber { get; private set; }

        public Asset Asset { get; private set; }


    }
}
