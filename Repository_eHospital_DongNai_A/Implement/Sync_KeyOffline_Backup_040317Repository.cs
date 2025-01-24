namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sync_KeyOffline_Backup_040317Repository : BaseRepository<Sync_KeyOffline_Backup_040317>
    , ISync_KeyOffline_Backup_040317Repository
    {
    private readonly Context _context;
    public Sync_KeyOffline_Backup_040317Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

