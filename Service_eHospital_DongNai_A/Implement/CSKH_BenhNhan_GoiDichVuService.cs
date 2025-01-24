namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_BenhNhan_GoiDichVuService : BaseService<CSKH_BenhNhan_GoiDichVu, ICSKH_BenhNhan_GoiDichVuRepository>
    , ICSKH_BenhNhan_GoiDichVuService
    {
    private readonly ICSKH_BenhNhan_GoiDichVuRepository _CSKH_BenhNhan_GoiDichVuRepository;
    public CSKH_BenhNhan_GoiDichVuService(ICSKH_BenhNhan_GoiDichVuRepository CSKH_BenhNhan_GoiDichVuRepository) : base(CSKH_BenhNhan_GoiDichVuRepository)
    {
    _CSKH_BenhNhan_GoiDichVuRepository = CSKH_BenhNhan_GoiDichVuRepository;
    }
    }
    }

