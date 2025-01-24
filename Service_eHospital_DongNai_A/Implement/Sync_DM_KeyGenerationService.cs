namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_DM_KeyGenerationService : BaseService<Sync_DM_KeyGeneration, ISync_DM_KeyGenerationRepository>
    , ISync_DM_KeyGenerationService
    {
    private readonly ISync_DM_KeyGenerationRepository _Sync_DM_KeyGenerationRepository;
    public Sync_DM_KeyGenerationService(ISync_DM_KeyGenerationRepository Sync_DM_KeyGenerationRepository) : base(Sync_DM_KeyGenerationRepository)
    {
    _Sync_DM_KeyGenerationRepository = Sync_DM_KeyGenerationRepository;
    }
    }
    }

