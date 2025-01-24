namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_BenhNhanRepository : BaseRepository<KSK_HopDong_BenhNhan>
    , IKSK_HopDong_BenhNhanRepository
    {
    private readonly Context _context;
    public KSK_HopDong_BenhNhanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

