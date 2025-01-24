namespace Service_eHospital_DongNai_A.Implement
{
    public class HoaDonVienPhiService : BaseService<HoaDonVienPhi, IHoaDonVienPhiRepository>
    , IHoaDonVienPhiService
    {
    private readonly IHoaDonVienPhiRepository _HoaDonVienPhiRepository;
    public HoaDonVienPhiService(IHoaDonVienPhiRepository HoaDonVienPhiRepository) : base(HoaDonVienPhiRepository)
    {
    _HoaDonVienPhiRepository = HoaDonVienPhiRepository;
    }
    }
    }

