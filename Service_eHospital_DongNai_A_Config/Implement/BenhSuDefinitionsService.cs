namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class BenhSuDefinitionsService : BaseService<BenhSuDefinitions, IBenhSuDefinitionsRepository>
    , IBenhSuDefinitionsService
    {
    private readonly IBenhSuDefinitionsRepository _BenhSuDefinitionsRepository;
    public BenhSuDefinitionsService(IBenhSuDefinitionsRepository BenhSuDefinitionsRepository) : base(BenhSuDefinitionsRepository)
    {
    _BenhSuDefinitionsRepository = BenhSuDefinitionsRepository;
    }
    }
    }

