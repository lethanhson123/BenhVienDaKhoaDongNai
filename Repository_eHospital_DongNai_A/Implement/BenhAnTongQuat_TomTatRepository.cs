namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TomTatRepository : BaseRepository<BenhAnTongQuat_TomTat>
    , IBenhAnTongQuat_TomTatRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_TomTatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

