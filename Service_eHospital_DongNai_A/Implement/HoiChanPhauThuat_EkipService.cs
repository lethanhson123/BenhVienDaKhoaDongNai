namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChanPhauThuat_EkipService : BaseService<HoiChanPhauThuat_Ekip, IHoiChanPhauThuat_EkipRepository>
    , IHoiChanPhauThuat_EkipService
    {
    private readonly IHoiChanPhauThuat_EkipRepository _HoiChanPhauThuat_EkipRepository;
    public HoiChanPhauThuat_EkipService(IHoiChanPhauThuat_EkipRepository HoiChanPhauThuat_EkipRepository) : base(HoiChanPhauThuat_EkipRepository)
    {
    _HoiChanPhauThuat_EkipRepository = HoiChanPhauThuat_EkipRepository;
    }
    }
    }

