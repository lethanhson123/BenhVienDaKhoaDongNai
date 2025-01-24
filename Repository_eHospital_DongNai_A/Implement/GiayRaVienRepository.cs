namespace Repository_eHospital_DongNai_A.Implement
{
    public class GiayRaVienRepository : BaseRepository<GiayRaVien>
    , IGiayRaVienRepository
    {
    private readonly Context _context;
    public GiayRaVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

