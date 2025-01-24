namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChan_EkipService : BaseService<HoiChan_Ekip, IHoiChan_EkipRepository>
    , IHoiChan_EkipService
    {
    private readonly IHoiChan_EkipRepository _HoiChan_EkipRepository;
    public HoiChan_EkipService(IHoiChan_EkipRepository HoiChan_EkipRepository) : base(HoiChan_EkipRepository)
    {
    _HoiChan_EkipRepository = HoiChan_EkipRepository;
    }
    }
    }

