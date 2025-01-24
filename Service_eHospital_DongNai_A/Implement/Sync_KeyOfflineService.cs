namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_KeyOfflineService : BaseService<Sync_KeyOffline, ISync_KeyOfflineRepository>
    , ISync_KeyOfflineService
    {
    private readonly ISync_KeyOfflineRepository _Sync_KeyOfflineRepository;
    public Sync_KeyOfflineService(ISync_KeyOfflineRepository Sync_KeyOfflineRepository) : base(Sync_KeyOfflineRepository)
    {
    _Sync_KeyOfflineRepository = Sync_KeyOfflineRepository;
    }
    }
    }

