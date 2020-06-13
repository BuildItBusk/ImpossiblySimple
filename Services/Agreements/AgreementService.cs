using Domain;
using Services.EFCore;
using System;
using System.Threading.Tasks;

namespace Services.Agreements
{
    public class AgreementService
    {
        private readonly MyContext _myContext;

        public AgreementService(MyContext myContext)
        {
            _myContext = myContext ?? throw new ArgumentNullException(nameof(myContext));
        }

        public async Task CreateAgreement(AgreementDto agreementDto)
        {
            var asset = new Asset(DateTime.Now);
            var agreement = new Agreement(asset);
            _myContext.Agreements.Add(agreement);
            await _myContext.SaveChangesAsync();
        }
    }
}
