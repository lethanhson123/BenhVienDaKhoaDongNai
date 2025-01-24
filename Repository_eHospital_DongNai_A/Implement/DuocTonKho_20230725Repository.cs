namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_20230725Repository : BaseRepository<DuocTonKho_20230725>
    , IDuocTonKho_20230725Repository
    {
    private readonly Context _context;
    public DuocTonKho_20230725Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

