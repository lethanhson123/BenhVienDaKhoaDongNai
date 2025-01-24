namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_HopDong_BenhNhan_DichVuService : BaseService<KSK_HopDong_BenhNhan_DichVu, IKSK_HopDong_BenhNhan_DichVuRepository>
    , IKSK_HopDong_BenhNhan_DichVuService
    {
    private readonly IKSK_HopDong_BenhNhan_DichVuRepository _KSK_HopDong_BenhNhan_DichVuRepository;
    public KSK_HopDong_BenhNhan_DichVuService(IKSK_HopDong_BenhNhan_DichVuRepository KSK_HopDong_BenhNhan_DichVuRepository) : base(KSK_HopDong_BenhNhan_DichVuRepository)
    {
    _KSK_HopDong_BenhNhan_DichVuRepository = KSK_HopDong_BenhNhan_DichVuRepository;
    }
    }
    }

