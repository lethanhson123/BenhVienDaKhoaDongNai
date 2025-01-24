namespace Repository_eHospital_DongNai_A.Implement
{
    public class Duoc_KiemKeRepository : BaseRepository<Duoc_KiemKe>
    , IDuoc_KiemKeRepository
    {
    private readonly Context _context;
    public Duoc_KiemKeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

