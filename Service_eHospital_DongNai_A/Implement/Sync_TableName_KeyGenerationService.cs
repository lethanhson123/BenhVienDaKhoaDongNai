namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_TableName_KeyGenerationService : BaseService<Sync_TableName_KeyGeneration, ISync_TableName_KeyGenerationRepository>
    , ISync_TableName_KeyGenerationService
    {
    private readonly ISync_TableName_KeyGenerationRepository _Sync_TableName_KeyGenerationRepository;
    public Sync_TableName_KeyGenerationService(ISync_TableName_KeyGenerationRepository Sync_TableName_KeyGenerationRepository) : base(Sync_TableName_KeyGenerationRepository)
    {
    _Sync_TableName_KeyGenerationRepository = Sync_TableName_KeyGenerationRepository;
    }
    }
    }

