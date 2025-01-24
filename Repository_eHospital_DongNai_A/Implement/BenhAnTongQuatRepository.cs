namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuatRepository : BaseRepository<BenhAnTongQuat>
    , IBenhAnTongQuatRepository
    {
    private readonly Context _context;
    public BenhAnTongQuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

