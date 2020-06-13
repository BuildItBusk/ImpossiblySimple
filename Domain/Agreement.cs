using System;

namespace Domain
{
    public class Agreement : AuditableEntity
    {
        public Agreement(Asset asset)
        {
            Asset = asset ?? throw new ArgumentNullException(nameof(asset));
        }

        public int Id { get; private set; }

        public int AgreementNumber { get; private set; }

        public Asset Asset { get; private set; }


    }
}
