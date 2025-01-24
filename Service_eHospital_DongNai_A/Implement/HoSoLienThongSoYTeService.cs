namespace Service_eHospital_DongNai_A.Implement
{
    public class HoSoLienThongSoYTeService : BaseService<HoSoLienThongSoYTe, IHoSoLienThongSoYTeRepository>
    , IHoSoLienThongSoYTeService
    {
    private readonly IHoSoLienThongSoYTeRepository _HoSoLienThongSoYTeRepository;
    public HoSoLienThongSoYTeService(IHoSoLienThongSoYTeRepository HoSoLienThongSoYTeRepository) : base(HoSoLienThongSoYTeRepository)
    {
    _HoSoLienThongSoYTeRepository = HoSoLienThongSoYTeRepository;
    }
    }
    }

