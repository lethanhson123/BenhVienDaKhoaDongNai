namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_DichVuRepository : BaseRepository<KSK_HopDong_DichVu>
    , IKSK_HopDong_DichVuRepository
    {
    private readonly Context _context;
    public KSK_HopDong_DichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

