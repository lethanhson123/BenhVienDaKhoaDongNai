namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_RHMRepository : BaseRepository<BenhAnTongQuat_RHM>
    , IBenhAnTongQuat_RHMRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_RHMRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

