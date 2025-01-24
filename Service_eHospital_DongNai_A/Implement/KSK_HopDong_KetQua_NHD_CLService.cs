namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_KetQua_NHD_CLService : BaseService<KSK_HopDong_KetQua_NHD_CL, IKSK_HopDong_KetQua_NHD_CLRepository>
    , IKSK_HopDong_KetQua_NHD_CLService
    {
    private readonly IKSK_HopDong_KetQua_NHD_CLRepository _KSK_HopDong_KetQua_NHD_CLRepository;
    public KSK_HopDong_KetQua_NHD_CLService(IKSK_HopDong_KetQua_NHD_CLRepository KSK_HopDong_KetQua_NHD_CLRepository) : base(KSK_HopDong_KetQua_NHD_CLRepository)
    {
    _KSK_HopDong_KetQua_NHD_CLRepository = KSK_HopDong_KetQua_NHD_CLRepository;
    }
    }
    }

