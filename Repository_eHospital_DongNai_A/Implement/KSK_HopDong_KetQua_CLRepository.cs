namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_KetQua_CLRepository : BaseRepository<KSK_HopDong_KetQua_CL>
    , IKSK_HopDong_KetQua_CLRepository
    {
    private readonly Context _context;
    public KSK_HopDong_KetQua_CLRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

