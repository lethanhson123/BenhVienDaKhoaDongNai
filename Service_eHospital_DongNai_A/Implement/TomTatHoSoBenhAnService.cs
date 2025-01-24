namespace Service_eHospital_DongNai_A.Implement
{
    public class TomTatHoSoBenhAnService : BaseService<TomTatHoSoBenhAn, ITomTatHoSoBenhAnRepository>
    , ITomTatHoSoBenhAnService
    {
    private readonly ITomTatHoSoBenhAnRepository _TomTatHoSoBenhAnRepository;
    public TomTatHoSoBenhAnService(ITomTatHoSoBenhAnRepository TomTatHoSoBenhAnRepository) : base(TomTatHoSoBenhAnRepository)
    {
    _TomTatHoSoBenhAnRepository = TomTatHoSoBenhAnRepository;
    }
    }
    }

