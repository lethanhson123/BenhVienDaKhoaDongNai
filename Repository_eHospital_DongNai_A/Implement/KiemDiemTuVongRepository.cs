namespace Repository_eHospital_DongNai_A.Implement
{
    public class KiemDiemTuVongRepository : BaseRepository<KiemDiemTuVong>
    , IKiemDiemTuVongRepository
    {
    private readonly Context _context;
    public KiemDiemTuVongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

