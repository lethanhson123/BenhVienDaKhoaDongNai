namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sync_KeyManagerRepository : BaseRepository<Sync_KeyManager>
    , ISync_KeyManagerRepository
    {
    private readonly Context _context;
    public Sync_KeyManagerRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

