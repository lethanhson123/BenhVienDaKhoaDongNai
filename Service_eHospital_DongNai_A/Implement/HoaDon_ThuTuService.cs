namespace Service_eHospital_DongNai_A.Implement
{
    public class HoaDon_ThuTuService : BaseService<HoaDon_ThuTu, IHoaDon_ThuTuRepository>
    , IHoaDon_ThuTuService
    {
    private readonly IHoaDon_ThuTuRepository _HoaDon_ThuTuRepository;
    public HoaDon_ThuTuService(IHoaDon_ThuTuRepository HoaDon_ThuTuRepository) : base(HoaDon_ThuTuRepository)
    {
    _HoaDon_ThuTuRepository = HoaDon_ThuTuRepository;
    }
    }
    }

