namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChanPhauThuatService : BaseService<HoiChanPhauThuat, IHoiChanPhauThuatRepository>
    , IHoiChanPhauThuatService
    {
    private readonly IHoiChanPhauThuatRepository _HoiChanPhauThuatRepository;
    public HoiChanPhauThuatService(IHoiChanPhauThuatRepository HoiChanPhauThuatRepository) : base(HoiChanPhauThuatRepository)
    {
    _HoiChanPhauThuatRepository = HoiChanPhauThuatRepository;
    }
    }
    }

