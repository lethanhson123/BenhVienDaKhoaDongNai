namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhNhan_HinhAnhRepository : BaseRepository<BenhNhan_HinhAnh>
    , IBenhNhan_HinhAnhRepository
    {
    private readonly Context _context;
    public BenhNhan_HinhAnhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

