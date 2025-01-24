namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnSanKhoaRepository : BaseRepository<BenhAnSanKhoa>
    , IBenhAnSanKhoaRepository
    {
    private readonly Context _context;
    public BenhAnSanKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

