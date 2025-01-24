namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonDauKy_20241230Repository : BaseRepository<DuocTonDauKy_20241230>
    , IDuocTonDauKy_20241230Repository
    {
    private readonly Context _context;
    public DuocTonDauKy_20241230Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

