namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_DichVuService : BaseService<KSK_HopDong_DichVu, IKSK_HopDong_DichVuRepository>
    , IKSK_HopDong_DichVuService
    {
    private readonly IKSK_HopDong_DichVuRepository _KSK_HopDong_DichVuRepository;
    public KSK_HopDong_DichVuService(IKSK_HopDong_DichVuRepository KSK_HopDong_DichVuRepository) : base(KSK_HopDong_DichVuRepository)
    {
    _KSK_HopDong_DichVuRepository = KSK_HopDong_DichVuRepository;
    }
    }
    }

