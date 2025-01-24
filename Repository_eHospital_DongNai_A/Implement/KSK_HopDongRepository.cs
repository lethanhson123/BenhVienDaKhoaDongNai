namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_HopDongRepository : BaseRepository<KSK_HopDong>
    , IKSK_HopDongRepository
    {
    private readonly Context _context;
    public KSK_HopDongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

