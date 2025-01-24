namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TMHRepository : BaseRepository<BenhAnTongQuat_TMH>
    , IBenhAnTongQuat_TMHRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_TMHRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

