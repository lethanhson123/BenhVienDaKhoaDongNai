namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChan_BenhLyService : BaseService<HoiChan_BenhLy, IHoiChan_BenhLyRepository>
    , IHoiChan_BenhLyService
    {
    private readonly IHoiChan_BenhLyRepository _HoiChan_BenhLyRepository;
    public HoiChan_BenhLyService(IHoiChan_BenhLyRepository HoiChan_BenhLyRepository) : base(HoiChan_BenhLyRepository)
    {
    _HoiChan_BenhLyRepository = HoiChan_BenhLyRepository;
    }
    }
    }

