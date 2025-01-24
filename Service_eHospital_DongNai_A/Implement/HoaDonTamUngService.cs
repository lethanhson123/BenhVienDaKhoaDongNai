namespace Service_eHospital_DongNai_A.Implement
{
    public class HoaDonTamUngService : BaseService<HoaDonTamUng, IHoaDonTamUngRepository>
    , IHoaDonTamUngService
    {
    private readonly IHoaDonTamUngRepository _HoaDonTamUngRepository;
    public HoaDonTamUngService(IHoaDonTamUngRepository HoaDonTamUngRepository) : base(HoaDonTamUngRepository)
    {
    _HoaDonTamUngRepository = HoaDonTamUngRepository;
    }
    }
    }

