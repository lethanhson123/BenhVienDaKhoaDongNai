namespace Service.Implement
{
    public class ThanhVienLichSuTruyCapService : BaseService<ThanhVienLichSuTruyCap, IThanhVienLichSuTruyCapRepository>
    , IThanhVienLichSuTruyCapService
    {
        private readonly IThanhVienLichSuTruyCapRepository _ThanhVienLichSuTruyCapRepository;
        public ThanhVienLichSuTruyCapService(IThanhVienLichSuTruyCapRepository ThanhVienLichSuTruyCapRepository) : base(ThanhVienLichSuTruyCapRepository)
        {
            _ThanhVienLichSuTruyCapRepository = ThanhVienLichSuTruyCapRepository;
        }
        public override void Initialization(ThanhVienLichSuTruyCap model)
        {
            BaseInitialization(model);
            if (model.NgayGhiNhan == null)
            {
                model.NgayGhiNhan = GlobalHelper.InitializationDateTime;
            }
        }
    }
}

