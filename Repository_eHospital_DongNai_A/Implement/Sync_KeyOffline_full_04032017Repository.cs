namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sync_KeyOffline_full_04032017Repository : BaseRepository<Sync_KeyOffline_full_04032017>
    , ISync_KeyOffline_full_04032017Repository
    {
    private readonly Context _context;
    public Sync_KeyOffline_full_04032017Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

