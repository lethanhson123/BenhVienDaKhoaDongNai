using Microsoft.AspNetCore.Hosting;

namespace Service.Implement
{
    public class TrucBanNhatKyService : BaseService<TrucBanNhatKy, ITrucBanNhatKyRepository>
    , ITrucBanNhatKyService
    {
        private readonly ITrucBanNhatKyRepository _TrucBanNhatKyRepository;
        public TrucBanNhatKyService(ITrucBanNhatKyRepository TrucBanNhatKyRepository) : base(TrucBanNhatKyRepository)
        {
            _TrucBanNhatKyRepository = TrucBanNhatKyRepository;
        }
        public override void Initialization(TrucBanNhatKy model)
        {
            BaseInitialization(model);

            model.NgayGhiNhan = GlobalHelper.InitializationDateTime;           
        }
    }
}

