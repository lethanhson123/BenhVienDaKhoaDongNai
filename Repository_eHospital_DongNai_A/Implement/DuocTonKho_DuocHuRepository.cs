namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_DuocHuRepository : BaseRepository<DuocTonKho_DuocHu>
    , IDuocTonKho_DuocHuRepository
    {
    private readonly Context _context;
    public DuocTonKho_DuocHuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

