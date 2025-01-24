namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_BenhNhanService : BaseService<KSK_HopDong_BenhNhan, IKSK_HopDong_BenhNhanRepository>
    , IKSK_HopDong_BenhNhanService
    {
    private readonly IKSK_HopDong_BenhNhanRepository _KSK_HopDong_BenhNhanRepository;
    public KSK_HopDong_BenhNhanService(IKSK_HopDong_BenhNhanRepository KSK_HopDong_BenhNhanRepository) : base(KSK_HopDong_BenhNhanRepository)
    {
    _KSK_HopDong_BenhNhanRepository = KSK_HopDong_BenhNhanRepository;
    }
    }
    }

