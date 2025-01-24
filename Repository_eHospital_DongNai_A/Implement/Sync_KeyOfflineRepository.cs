namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sync_KeyOfflineRepository : BaseRepository<Sync_KeyOffline>
    , ISync_KeyOfflineRepository
    {
    private readonly Context _context;
    public Sync_KeyOfflineRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

