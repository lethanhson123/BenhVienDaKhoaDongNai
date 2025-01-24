namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuatRepository : BaseRepository<BenhAnPhauThuat>
    , IBenhAnPhauThuatRepository
    {
    private readonly Context _context;
    public BenhAnPhauThuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

