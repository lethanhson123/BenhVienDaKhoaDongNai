namespace Repository_eHospital_DongNai_A.Implement
{
    public class GhiChuDuocRepository : BaseRepository<GhiChuDuoc>
    , IGhiChuDuocRepository
    {
    private readonly Context _context;
    public GhiChuDuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

