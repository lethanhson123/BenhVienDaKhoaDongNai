namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_DM_BenhNhan_KeyGenerationService : BaseService<Sync_DM_BenhNhan_KeyGeneration, ISync_DM_BenhNhan_KeyGenerationRepository>
    , ISync_DM_BenhNhan_KeyGenerationService
    {
    private readonly ISync_DM_BenhNhan_KeyGenerationRepository _Sync_DM_BenhNhan_KeyGenerationRepository;
    public Sync_DM_BenhNhan_KeyGenerationService(ISync_DM_BenhNhan_KeyGenerationRepository Sync_DM_BenhNhan_KeyGenerationRepository) : base(Sync_DM_BenhNhan_KeyGenerationRepository)
    {
    _Sync_DM_BenhNhan_KeyGenerationRepository = Sync_DM_BenhNhan_KeyGenerationRepository;
    }
    }
    }

