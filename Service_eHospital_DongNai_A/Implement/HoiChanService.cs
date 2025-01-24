namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChanService : BaseService<HoiChan, IHoiChanRepository>
    , IHoiChanService
    {
    private readonly IHoiChanRepository _HoiChanRepository;
    public HoiChanService(IHoiChanRepository HoiChanRepository) : base(HoiChanRepository)
    {
    _HoiChanRepository = HoiChanRepository;
    }
    }
    }

