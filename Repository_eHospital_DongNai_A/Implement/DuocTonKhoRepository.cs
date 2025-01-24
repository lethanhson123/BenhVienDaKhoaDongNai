namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonKhoRepository : BaseRepository<DuocTonKho>
    , IDuocTonKhoRepository
    {
    private readonly Context _context;
    public DuocTonKhoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

