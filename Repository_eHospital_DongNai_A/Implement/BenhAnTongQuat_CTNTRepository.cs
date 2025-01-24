namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_CTNTRepository : BaseRepository<BenhAnTongQuat_CTNT>
    , IBenhAnTongQuat_CTNTRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_CTNTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

