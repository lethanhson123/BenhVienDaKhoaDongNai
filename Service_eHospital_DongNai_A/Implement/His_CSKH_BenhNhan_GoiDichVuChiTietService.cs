namespace Service_eHospital_DongNai_A.Implement
{
    public class His_CSKH_BenhNhan_GoiDichVuChiTietService : BaseService<His_CSKH_BenhNhan_GoiDichVuChiTiet, IHis_CSKH_BenhNhan_GoiDichVuChiTietRepository>
    , IHis_CSKH_BenhNhan_GoiDichVuChiTietService
    {
    private readonly IHis_CSKH_BenhNhan_GoiDichVuChiTietRepository _His_CSKH_BenhNhan_GoiDichVuChiTietRepository;
    public His_CSKH_BenhNhan_GoiDichVuChiTietService(IHis_CSKH_BenhNhan_GoiDichVuChiTietRepository His_CSKH_BenhNhan_GoiDichVuChiTietRepository) : base(His_CSKH_BenhNhan_GoiDichVuChiTietRepository)
    {
    _His_CSKH_BenhNhan_GoiDichVuChiTietRepository = His_CSKH_BenhNhan_GoiDichVuChiTietRepository;
    }
    }
    }

