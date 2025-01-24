namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_KeyManagerService : BaseService<Sync_KeyManager, ISync_KeyManagerRepository>
    , ISync_KeyManagerService
    {
    private readonly ISync_KeyManagerRepository _Sync_KeyManagerRepository;
    public Sync_KeyManagerService(ISync_KeyManagerRepository Sync_KeyManagerRepository) : base(Sync_KeyManagerRepository)
    {
    _Sync_KeyManagerRepository = Sync_KeyManagerRepository;
    }
    }
    }

