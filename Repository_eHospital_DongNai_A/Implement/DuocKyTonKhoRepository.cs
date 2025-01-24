namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocKyTonKhoRepository : BaseRepository<DuocKyTonKho>
    , IDuocKyTonKhoRepository
    {
    private readonly Context _context;
    public DuocKyTonKhoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

