namespace Service_eHospital_DongNai_A.Implement
{
    public class BHYT_Export_HisService : BaseService<BHYT_Export_His, IBHYT_Export_HisRepository>
    , IBHYT_Export_HisService
    {
    private readonly IBHYT_Export_HisRepository _BHYT_Export_HisRepository;
    public BHYT_Export_HisService(IBHYT_Export_HisRepository BHYT_Export_HisRepository) : base(BHYT_Export_HisRepository)
    {
    _BHYT_Export_HisRepository = BHYT_Export_HisRepository;
    }
    }
    }

