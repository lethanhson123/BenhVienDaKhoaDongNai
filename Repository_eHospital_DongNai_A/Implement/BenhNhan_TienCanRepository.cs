namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhNhan_TienCanRepository : BaseRepository<BenhNhan_TienCan>
    , IBenhNhan_TienCanRepository
    {
    private readonly Context _context;
    public BenhNhan_TienCanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

