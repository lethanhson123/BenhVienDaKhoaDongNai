namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_VTYTRepository : BaseRepository<BenhAnPhauThuat_VTYT>
    , IBenhAnPhauThuat_VTYTRepository
    {
    private readonly Context _context;
    public BenhAnPhauThuat_VTYTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

