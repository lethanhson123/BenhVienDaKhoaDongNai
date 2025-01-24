namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_GoiDichVuChiTietService : BaseService<CSKH_GoiDichVuChiTiet, ICSKH_GoiDichVuChiTietRepository>
    , ICSKH_GoiDichVuChiTietService
    {
    private readonly ICSKH_GoiDichVuChiTietRepository _CSKH_GoiDichVuChiTietRepository;
    public CSKH_GoiDichVuChiTietService(ICSKH_GoiDichVuChiTietRepository CSKH_GoiDichVuChiTietRepository) : base(CSKH_GoiDichVuChiTietRepository)
    {
    _CSKH_GoiDichVuChiTietRepository = CSKH_GoiDichVuChiTietRepository;
    }
    }
    }

