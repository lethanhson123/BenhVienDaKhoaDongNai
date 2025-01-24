namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_HopDongService : BaseService<KSK_HopDong, IKSK_HopDongRepository>
    , IKSK_HopDongService
    {
    private readonly IKSK_HopDongRepository _KSK_HopDongRepository;
    public KSK_HopDongService(IKSK_HopDongRepository KSK_HopDongRepository) : base(KSK_HopDongRepository)
    {
    _KSK_HopDongRepository = KSK_HopDongRepository;
    }
    }
    }

