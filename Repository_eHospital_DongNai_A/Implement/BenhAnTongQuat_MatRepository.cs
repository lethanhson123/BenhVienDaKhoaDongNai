namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_MatRepository : BaseRepository<BenhAnTongQuat_Mat>
    , IBenhAnTongQuat_MatRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_MatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

