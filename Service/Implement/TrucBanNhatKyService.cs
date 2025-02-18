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

            if (model.NgayGhiNhan == null)
            {
                model.NgayGhiNhan = GlobalHelper.InitializationDateTime;
            }
            if (model.ID == 0)
            {
                model.NgayGhiNhan = GlobalHelper.InitializationDateTime;
            }

            if (string.IsNullOrEmpty(model.Khu))
            {
                model.Khu = "A";
            }
            if (string.IsNullOrEmpty(model.Tang))
            {
                model.Tang = "G";
            }
            if (string.IsNullOrEmpty(model.Khoa))
            {
                model.Khoa = "Khám bệnh";
            }
        }
    }
}

