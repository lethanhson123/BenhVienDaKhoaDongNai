namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_KetQua_NHD_CLRepository : BaseRepository<KSK_HopDong_KetQua_NHD_CL>
    , IKSK_HopDong_KetQua_NHD_CLRepository
    {
    private readonly Context _context;
    public KSK_HopDong_KetQua_NHD_CLRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

