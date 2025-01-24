namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_GoiDichVuService : BaseService<KSK_HopDong_GoiDichVu, IKSK_HopDong_GoiDichVuRepository>
    , IKSK_HopDong_GoiDichVuService
    {
    private readonly IKSK_HopDong_GoiDichVuRepository _KSK_HopDong_GoiDichVuRepository;
    public KSK_HopDong_GoiDichVuService(IKSK_HopDong_GoiDichVuRepository KSK_HopDong_GoiDichVuRepository) : base(KSK_HopDong_GoiDichVuRepository)
    {
    _KSK_HopDong_GoiDichVuRepository = KSK_HopDong_GoiDichVuRepository;
    }
    }
    }

