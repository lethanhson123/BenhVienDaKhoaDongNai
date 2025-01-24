namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_TamDucRepository : BaseRepository<BenhAnPhauThuat_TamDuc>
    , IBenhAnPhauThuat_TamDucRepository
    {
    private readonly Context _context;
    public BenhAnPhauThuat_TamDucRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

