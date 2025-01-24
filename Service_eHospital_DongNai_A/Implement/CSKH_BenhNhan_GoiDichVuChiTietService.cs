namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_BenhNhan_GoiDichVuChiTietService : BaseService<CSKH_BenhNhan_GoiDichVuChiTiet, ICSKH_BenhNhan_GoiDichVuChiTietRepository>
    , ICSKH_BenhNhan_GoiDichVuChiTietService
    {
    private readonly ICSKH_BenhNhan_GoiDichVuChiTietRepository _CSKH_BenhNhan_GoiDichVuChiTietRepository;
    public CSKH_BenhNhan_GoiDichVuChiTietService(ICSKH_BenhNhan_GoiDichVuChiTietRepository CSKH_BenhNhan_GoiDichVuChiTietRepository) : base(CSKH_BenhNhan_GoiDichVuChiTietRepository)
    {
    _CSKH_BenhNhan_GoiDichVuChiTietRepository = CSKH_BenhNhan_GoiDichVuChiTietRepository;
    }
    }
    }

