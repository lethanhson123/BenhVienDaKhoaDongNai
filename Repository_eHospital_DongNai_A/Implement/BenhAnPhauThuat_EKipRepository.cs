namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_EKipRepository : BaseRepository<BenhAnPhauThuat_EKip>
    , IBenhAnPhauThuat_EKipRepository
    {
    private readonly Context _context;
    public BenhAnPhauThuat_EKipRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

