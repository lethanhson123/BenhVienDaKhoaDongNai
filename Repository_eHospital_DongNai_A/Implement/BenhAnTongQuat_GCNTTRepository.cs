namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GCNTTRepository : BaseRepository<BenhAnTongQuat_GCNTT>
    , IBenhAnTongQuat_GCNTTRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_GCNTTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

