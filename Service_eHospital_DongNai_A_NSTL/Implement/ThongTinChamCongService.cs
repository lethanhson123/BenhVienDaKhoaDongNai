namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class ThongTinChamCongService : BaseService<ThongTinChamCong, IThongTinChamCongRepository>
    , IThongTinChamCongService
    {
    private readonly IThongTinChamCongRepository _ThongTinChamCongRepository;
    public ThongTinChamCongService(IThongTinChamCongRepository ThongTinChamCongRepository) : base(ThongTinChamCongRepository)
    {
    _ThongTinChamCongRepository = ThongTinChamCongRepository;
    }
    }
    }

