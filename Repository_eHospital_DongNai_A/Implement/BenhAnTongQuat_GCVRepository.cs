namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GCVRepository : BaseRepository<BenhAnTongQuat_GCV>
    , IBenhAnTongQuat_GCVRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_GCVRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

