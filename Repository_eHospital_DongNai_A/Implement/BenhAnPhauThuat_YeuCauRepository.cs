namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_YeuCauRepository : BaseRepository<BenhAnPhauThuat_YeuCau>
    , IBenhAnPhauThuat_YeuCauRepository
    {
    private readonly Context _context;
    public BenhAnPhauThuat_YeuCauRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

