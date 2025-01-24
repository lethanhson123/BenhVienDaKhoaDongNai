namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_TiepNhan_KeyGenerationService : BaseService<Sync_TiepNhan_KeyGeneration, ISync_TiepNhan_KeyGenerationRepository>
    , ISync_TiepNhan_KeyGenerationService
    {
    private readonly ISync_TiepNhan_KeyGenerationRepository _Sync_TiepNhan_KeyGenerationRepository;
    public Sync_TiepNhan_KeyGenerationService(ISync_TiepNhan_KeyGenerationRepository Sync_TiepNhan_KeyGenerationRepository) : base(Sync_TiepNhan_KeyGenerationRepository)
    {
    _Sync_TiepNhan_KeyGenerationRepository = Sync_TiepNhan_KeyGenerationRepository;
    }
    }
    }

