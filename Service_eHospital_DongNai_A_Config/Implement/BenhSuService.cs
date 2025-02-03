namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class BenhSuService : BaseService<BenhSu, IBenhSuRepository>
    , IBenhSuService
    {
    private readonly IBenhSuRepository _BenhSuRepository;
    public BenhSuService(IBenhSuRepository BenhSuRepository) : base(BenhSuRepository)
    {
    _BenhSuRepository = BenhSuRepository;
    }
    }
    }

