using System;

namespace Services.Agreements
{
    public class AgreementDto
    {
        public int AgreementNumber { get; set; }

        public decimal Price { get; set; }

        public DateTime Expiration { get; set; }
    }
}
