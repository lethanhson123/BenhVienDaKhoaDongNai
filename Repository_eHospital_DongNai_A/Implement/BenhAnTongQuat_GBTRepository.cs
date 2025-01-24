namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GBTRepository : BaseRepository<BenhAnTongQuat_GBT>
    , IBenhAnTongQuat_GBTRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_GBTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

