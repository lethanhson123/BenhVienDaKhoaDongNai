namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_GoiDichVuRepository : BaseRepository<KSK_HopDong_GoiDichVu>
    , IKSK_HopDong_GoiDichVuRepository
    {
    private readonly Context _context;
    public KSK_HopDong_GoiDichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

