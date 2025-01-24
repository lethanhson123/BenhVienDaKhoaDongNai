namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_KetQua_CLService : BaseService<KSK_HopDong_KetQua_CL, IKSK_HopDong_KetQua_CLRepository>
    , IKSK_HopDong_KetQua_CLService
    {
    private readonly IKSK_HopDong_KetQua_CLRepository _KSK_HopDong_KetQua_CLRepository;
    public KSK_HopDong_KetQua_CLService(IKSK_HopDong_KetQua_CLRepository KSK_HopDong_KetQua_CLRepository) : base(KSK_HopDong_KetQua_CLRepository)
    {
    _KSK_HopDong_KetQua_CLRepository = KSK_HopDong_KetQua_CLRepository;
    }
    }
    }

