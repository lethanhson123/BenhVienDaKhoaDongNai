namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonDauKyRepository : BaseRepository<DuocTonDauKy>
    , IDuocTonDauKyRepository
    {
    private readonly Context _context;
    public DuocTonDauKyRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

