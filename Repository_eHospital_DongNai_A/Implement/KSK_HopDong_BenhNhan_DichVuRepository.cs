namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_BenhNhan_DichVuRepository : BaseRepository<KSK_HopDong_BenhNhan_DichVu>
    , IKSK_HopDong_BenhNhan_DichVuRepository
    {
    private readonly Context _context;
    public KSK_HopDong_BenhNhan_DichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

